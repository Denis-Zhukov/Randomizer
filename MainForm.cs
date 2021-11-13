using System.Diagnostics;
using System.Text.RegularExpressions;

namespace RandomizeCodeEvergyMonster;
public partial class MainForm : Form {

    char[] eng = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    char[] engCaps = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
    char[] rusCaps = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };

    public MainForm() {
        InitializeComponent();

    }

    private void Generate_Click(object sender, EventArgs e) {
        Regex regexDelimiter = new Regex(@"\,\s|\,");

        char[] validSymbols = Array.Empty<char>();
        string[] symbolsStr = regexDelimiter.Split(new Regex(@"\,$").Replace(Symbols.Text, "").Trim()).ToArray().Select<string, string>(el =>
        {
            if (el != "") return el[0].ToString();
            return "";
        }).ToArray();
        char[] symbols = Array.Empty<char>();
        if (symbolsStr[0] != "")
            symbols = symbolsStr.Select<string, char>(el =>
            {
                if (el.Length > 0) return el[0];
                else throw new Exception("В поле с символами указаны не символы!");
            }).ToArray();




        int length = 0;
        int maxNums = 0;
        bool save = SaveToFile.Checked;
        string filename = Filename.Text.Trim() != "" ? Filename.Text.Trim() : "codes.txt";
        bool uniq = GenerateUniq.Checked;
        int count = 0;

        if (!Int32.TryParse(Count.Text, out count) || count < 1) {
            MessageBox.Show($"Количество кодов это натуральное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!Int32.TryParse(LengthCodes.Text, out length) || length < 1) {
            MessageBox.Show($"Длина кода это натуральное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!Int32.TryParse(MaxNums.Text, out maxNums) || maxNums < 1) {
            MessageBox.Show($"Максимальное количество цифр это натуральное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (EngCaps.Checked) validSymbols = validSymbols.Concat(engCaps).ToArray();
        else if (Eng.Checked) validSymbols = validSymbols.Concat(eng).Concat(engCaps).ToArray();

        if (RusCaps.Checked) validSymbols = validSymbols.Concat(rusCaps).ToArray();
        else if (Rus.Checked) validSymbols = validSymbols.Concat(rus).Concat(rusCaps).ToArray();

        string[] numsStr = regexDelimiter.Split(Numbers.Text).ToArray();
        int[] nums;
        if (numsStr[0] != "") nums = new int[numsStr.Length];
        else nums = Array.Empty<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (Int32.TryParse(numsStr[i], out int x)) nums[i] = x;
            else {
                MessageBox.Show($"В допустимых цифрах указан символ отличающийся от цифры!\n{i + 1} символ({numsStr[i]}) неверный.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        validSymbols = validSymbols.Concat(symbols).ToArray();

        new ShowNewCodes(GenerateCode(count, validSymbols, nums, length, maxNums, save, filename, uniq)).Show();
    }

    private string[] GenerateCode(int count, char[] symbols, int[] nums, int lengthCode, int maxNums, bool save, string filename, bool uniq) {
        string[] codes = new string[count];
        for (int i = 0; i < count; i++) {
            string code = "";
            for (int j = 0; j < lengthCode - maxNums; j++)
                code += GetRandomSymbol(symbols);
            for (int j = 0; j < maxNums; j++)
                code += GetRandomSymbol(symbols, nums);

            codes[i] = code.Shuffle();
            bool uniqCode = true;
            if (uniq) {
                try {
                    if (!File.Exists("./" + filename)) File.Create("./" + filename).Dispose();
                    using (StreamReader sr = new StreamReader("./" + filename)) {
                        string str;
                        while ((str = sr.ReadLine()) != null) {
                            if (str == codes[i]) {
                                uniqCode = false;
                                break;
                            }
                        }
                    }
                }
                catch (Exception e) {
                    MessageBox.Show($"Ошибка работы с файлом.\nНеверное имя, либо программа не имеет доступа к файлам\n{e.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!uniqCode) i--;
            }

            if ((save && !uniq) || (save && uniq && uniqCode)) {
                try {
                    using (StreamWriter sw = new StreamWriter("./" + filename, true))
                        sw.WriteLine(codes[i]);
                }
                catch (Exception e) {
                    MessageBox.Show($"Ошибка работы с файлом.\nНеверное имя, либо программа не имеет доступа к файлам\n{e.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        return codes;
    }

    private string GetRandomSymbol<T>(T[] arr) {
        Random r = new Random();
        if (arr.Length != 0) return arr[r.Next(0, arr.Length)].ToString();
        return "ERROR";
    }

    private string GetRandomSymbol<T, K>(T[] arr1, K[] arr2) {
        Random r = new Random();
        if (r.Next(0, 2) == 0 && arr1.Length != 0)
            return arr1[r.Next(0, arr1.Length)].ToString();
        else if (arr2.Length != 0) return arr2[r.Next(0, arr2.Length)].ToString();
        return "ERROR";
    }

    private void SaveToFile_CheckedChanged(object sender, EventArgs e) => Filename.Enabled = SaveToFile.Checked;

    private void показатьФайлСКодамиToolStripMenuItem_Click(object sender, EventArgs e) {
        string filename = Filename.Text.Trim() != "" ? Filename.Text.Trim() : "codes.txt";
        try {
            if (!File.Exists("./" + filename)) File.Create("./" + filename).Dispose();
            Process.Start("notepad.exe", "./" + filename);
        }
        catch (Exception ex) {
            MessageBox.Show($"Ошибка работы с файлом.\nНеверное имя, либо программа не имеет доступа к файлам\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
