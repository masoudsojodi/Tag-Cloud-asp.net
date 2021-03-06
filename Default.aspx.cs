﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected string _Model;
    protected void Page_Load(object sender, EventArgs e)
    {
        var phrases = new string[] { 
            "71)منبع خبر: Telegram_fan2+ ==== تاریخ) ۱۳۹۵/۰۵/۰۸=====نام گروه)سپاه دانشتجمع کارگران کارخانه زغالشویی زرند جلوی فرمانداری و دادگستری زرند قشر زیادی از جامعه زرند را کارگران شامل می شوند که متاسفانه در سال های اخیر به دلیل رکود ایجاد شده در اقتصاد کشور اولین قشری که بیشترین ضربه را از این رکود چندین ساله خورده اند همین کارگران هساند. به گزارش تارنگار حقوق بشر در ایران به نقل از صدای زرند، در روزهای اخیر شاهد تجمع اعتراضی جمع زیادی از کارگران بخش های مختلف صنعتی و معدنی شهرستان زرند بوده ایم که این بار کارگران کارخانه زغالشویی با تجمع جلوی فرمانداری و دادگستری این شهر مراتب اعتراض آرام خود را به گوش مسئولین رساندند. در ابتدا این کارگران که تعداد آنان طبق گفته حاضرین حدود ۱۰۰ نفر بوده است جلوی فرمانداری تجمع کردند. این جمعیت پس از اعتراض به سمت دادگستری زرند و دفتر امام جمعه زرند حرکت کردند. شاید مدیریت این شرایط آن هم با وجود رکود اقتصادی کنونی برای کارفرمایان و مدیران اجرایی شهرستانی و استانی کاری سخت باشد، اما به گفته کارگران حاضر در این تجمع، در همین شرایط رکود اقتصادی هم استخراج و فروش زغال سنگ از معادن شهرستان های زرند، کوهبنان و راور در حال انجام می باشد اما حدود ۴ ماه است که حقوقی به کارگران این معادن پرداخت نشده است و این موضوع شرایط زندگی این عزیزان به شدت مختل کرده است. @irannc"
            , "72)منبع خبر: Telegram_fan2+ ==== تاریخ) ۱۳۹۵/۰۵/۰۸=====نام گروه)سپاه دانشزنجان؛ تحصن ۵۰۰ نفر از کارگران ایران ترانسفو جمعی از کارگران ایران ترانسفو زنجان از روز گذشته در محل این شرکت تجمع کردند. به گزارش تارنگار حقوق بشر در ایران به نقل از فارس، یکی از کارگران این شرکت اظهار کرد: اعتراض کارگران در پی فروش ۳۵ درصد از سهام ایران ترانسفورماتور به مهدی مومنی طاهری و تغییراتی که قرار است، در بخش کارگری ایجاد شود، انجام شده است. وی با اشاره به اینکه تحصن قریب به ۵۰۰ نفر از کارگران از دیروز آغاز شده است، گفت: با وجود اعتراضات انجام شده هنوز پاسخی از سوی مسؤولان شرکت به تجمع‌کنندگان داده نشده است. بحث هلدینگ ایران ترانسفو و همچنین تغییر قرارداد کارگران، بحث تعدیل نیرو در بخش کارگری و تغییراتی که قرار است، در بخش بیمه‌ کارگران ایجاد شود، موجب اعتراض کارگران شده است. گفته می شود، عصر امروز جلسه‌ای با حضور مدیران شرکت و کارگران برای رسیدگی به وضعیت جدید آن تشکیل شود. شرکت ایران ترانسفو بزرگترین تولیدکننده و صادرکننده ترانسفورماتور تحت لیسانس شرکت زیمنس آلمان در خاورمیانه است. در سال ۱۳۴۵ شرکت ایران ترانسفو توسط شرکت برق منطقه‌ای تهران، شرکت زیمنس آلمان و بانک توسعه صنعت و معدن ایران تشکیل شد. در سال ۱۳۴۷ نخستین کارخانه ایران ترانسفو در شهر ری در زمینی به مساحت ۵۸ هزار مترمربع با هدف تولید ترانسفورماتورهای توزیع به بهره‌برداری رسید. @irannc"
        };
        //var phrases = new string[] { Resources.TagCloudInput };
        var model = new TagCloudAnalyzer()
            .ComputeTagCloud(phrases)
            .Shuffle();

        foreach (var item in model)
	    {
                _Model+= "<span class='tag kind-"+item.Category+"'"+ " title="+item.Count + ">" +item.Text+ "</span>";
	    }
        
       
        
    }
}