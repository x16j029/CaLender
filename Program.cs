using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    class Program
    {
        static void Main(string[] args)
        {
            
                DateTime datenow = DateTime.Now;

                Console.Write("{0}年{1}月{2}日{3}時{4}分\n", datenow.Year, datenow.Month, datenow.Day, datenow.Hour, datenow.Minute);

                DateTime dateFirst = DateTime.Parse(string.Format("{0}/{1}/1", datenow.Year, datenow.Month));
                DisplayCalendar(dateFirst);
                Console.ReadLine();
            }
            //1カ月分のカレンダーを画面に表示する
            //パラメータ
            //　　dateFirst : 表示したい年月の一日を表すDateTime
            static void DisplayCalendar(DateTime dateFirst)
            {
                int week;
                int month = dateFirst.Month;

                //曜日タイトルの表示
                Console.Write("----------------\n");
                Console.Write("日 月 火 水 木 金 土\n");

                //1日の開始地点まで空白を表示する
                for (week = 0; week < (int)dateFirst.DayOfWeek; week++)
                    Console.Write("   ");

                //月の終わりの日まで１週間ごとに日にちを表示する
                while (month == dateFirst.Month)
                {
                    for (; week < 7 && month == dateFirst.Month; week++)
                    {
                        Console.Write("{0,2} ", dateFirst.Day);
                        dateFirst = dateFirst.AddDays(1); //翌日にする
                    }
                    Console.Write("\n");
                    week = 0;
                }
          }
     }
  }
