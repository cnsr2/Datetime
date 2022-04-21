// See https://aka.ms/new-console-template for more information
    Console.WriteLine(DateTime.Now);  //günün tarihini getirir
    Console.WriteLine(DateTime.Now.Date);   // saatsiz tarihi getirir 
    Console.WriteLine(DateTime.Now.Day);   // günü getirir 
    Console.WriteLine(DateTime.Now.Hour);  // saati getirir
    Console.WriteLine(DateTime.Now.Month); // içinde bulunduğu ayı getirir 
    Console.WriteLine(DateTime.Now.Year);  // içinde bulunduğu yılı getirir
    Console.WriteLine(DateTime.Now.Minute); // dakikayı getirir 
    Console.WriteLine(DateTime.Now.Second); // saniyeyi getirir 

    Console.WriteLine(DateTime.Now.DayOfWeek); // haftanın gününü getirir
    Console.WriteLine(DateTime.Now.DayOfYear); // yılın gününü getirir 

    // datetime formatları

    Console.WriteLine(DateTime.Now.ToString("dd")); // 21
    Console.WriteLine(DateTime.Now.ToString("ddd")); // Thr
    Console.WriteLine(DateTime.Now.ToString("dddd")); // Thursday


    Console.WriteLine(DateTime.Now.ToString("MM")); // 4
    Console.WriteLine(DateTime.Now.ToString("MMM")); // apr
    Console.WriteLine(DateTime.Now.ToString("MMMM")); // april

    Console.WriteLine(DateTime.Now.ToString("yy")); // 22
    Console.WriteLine(DateTime.Now.ToString("yyyy"));// 2022


    // Math kütüphanesi 

    Console.WriteLine(Math.Abs(-25)); // mutlak değerini alır örnek çıktı = 25 
    Console.WriteLine(Math.Sin(30)); // sin 30 değerini alır
    Console.WriteLine(Math.Cos(-25)); // cos değerini alır
    Console.WriteLine(Math.Tan(30)); // tan değerini alır

    Console.WriteLine(Math.Ceiling(22.3)); //  virgüllü sayılarda kendisinden büyük en küçük tam sayıya yuvarlar örnek 23 
    Console.WriteLine(Math.Round(22.3)); // en yakın tam sayıya yuvarlar 22  
    Console.WriteLine(Math.Round(22.7)); // 23 
    Console.WriteLine(Math.Floor(22.7)); // virgüllü sayılarda kendisinden küçük en büyük tam sayıya yuvarlar örnek 22

    Console.WriteLine(Math.Max(2,6)); // 6 
    Console.WriteLine(Math.Min(2,6)); // 2

    Console.WriteLine(Math.Pow(3,4));   // 3^4 ü verir 
    Console.WriteLine(Math.Sqrt(9));   // karekök alır
    Console.WriteLine(Math.Log(9));   // e tabanında logaritma alır 
    Console.WriteLine(Math.Exp(3));     // e üzeri 3 ü verir 
    Console.WriteLine(Math.Log10(10)); // 10 sayısının log 10 tabanındaki karşılığı

     
    

