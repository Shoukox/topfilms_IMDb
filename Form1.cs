using System;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

using AngleSharp;


namespace topimdb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async Task<string> LoadData()
        {
            try
            {
                string response = null;
                List<string> data = new List<string>();
                using (HttpClient hc = new HttpClient())
                {
                    HttpResponseMessage hrm = await hc.GetAsync("https://ru.wikipedia.org/wiki/250_%D0%BB%D1%83%D1%87%D1%88%D0%B8%D1%85_%D1%84%D0%B8%D0%BB%D1%8C%D0%BC%D0%BE%D0%B2_%D0%BF%D0%BE_%D0%B2%D0%B5%D1%80%D1%81%D0%B8%D0%B8_IMDb");
                    hrm.EnsureSuccessStatusCode();
                    response = await hrm.Content.ReadAsStringAsync();
                    textBoxFilms.Text = response;
                }
                using (BrowsingContext bc = new BrowsingContext(Configuration.Default))
                {
                    var document = await bc.OpenAsync(m => m.Content(response));
                    var list = document.QuerySelectorAll("tr").Skip(2);
                    foreach (var item in list)
                    {
                        var temp = item.QuerySelectorAll("td");
                        data.Add($"{temp[0].TextContent}. {temp[1].TextContent}\r\n   Год выпуска: {temp[2].TextContent}\r\n   Режиссер: {temp[3].TextContent}\r\n   Жанры: {temp[4].TextContent}\r\n\r\n");
                    }
                    if (!checkBoxRandom.Checked && !checkBox1.Checked)
                    {
                        string text = "";
                        foreach (var item in data)
                        {
                            text += item;
                        }
                        return $"Рейтинг фильмов по версии IMDb\r\n{document.QuerySelectorAll("span").First(m => m.ClassName == "mw-headline" && m.TextContent.StartsWith("Состояние")).TextContent}:\r\n{text}";
                    }
                    else if (checkBoxRandom.Checked)
                        return $"Случайный фильм:\r\n\r\n{data[new Random().Next(0, 250)]}";
                    else if (checkBox1.Checked)
                    {
                        var ab = textBoxFilters.Text.Split("-".ToCharArray());
                        bool contains = false;
                        string text = "";
                        foreach(var item in data)
                        {
                            contains = false;
                            foreach(var item1 in ab)
                            {
                                if (item.Contains(item1))
                                {
                                    contains = true;
                                    break;
                                }
                            }
                            if (contains) text += item;
                        }
                        return $"Фильтр: {string.Join(", ", ab)}\r\n\r\n{text}";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Попробуйте еще раз!\nОшибка: {e.Message}");
            }
            return null;
        }

        async private void buttonStart_Click(object sender, EventArgs e)
        {
            textBoxFilms.Text = await LoadData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Вводите текст в поле левее через дефис (драма-Крестный-Джордж). По этому тексту будут отсортированы фильмы (и по жанрам, и по режиссеру, и по названию)");
            }
        }
    }
}
