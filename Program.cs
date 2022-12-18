class Program{
    static void Main(){
        string information = Console.ReadLine();
        if(information == "A") Information();
        if(information == "B") Agent();
        if(information == "C") FT();
    }
    public void PrintAllInformation(){
        float[] number1 = {10.2f, 7.3f, 8.4f, 5.6f, 9.3f, 4.6f, 1.2f, 7.5f, 8.2f, 4.3f, 6.0f, 7.0f};
        float[] number2 = {9.2f, 5.2f, 8.9f, 7.1f, 9.3f, 2.2f, 1.7f, 5.2f, 9.1f, 8.4f, 2.1f, 2.3f};
        float[] number3 = {17.2f, 19, 23, 25.1f, 31, 32.1f, 17.0f, 14, 11.3f, 18.1f, 19.2f, 22};
        float[] number4 = {2.1f, 2.0f, 1.1f, 1.5f, 3.2f, 4.1f,2.2f, 2.2f, 1.3f, 1.4f, 5.0f, 4.1f};
        float[] number5 = {17.2f, 20, 23, 25.1f, 31, 4.1f, 17.0f, 14, 11.3f, 5.0f, 19.2f, 22f};
        double sum = number1.Sum();
        Console.WriteLine("ผลรวมค่า FT เท่ากับ "+sum );
        Console.WriteLine(number1);
    }
    public static void Information(){
        Console.WriteLine("มหาวิทยาลัยจุฬาลงกรณ์");
        Console.WriteLine("ห้องสมุดรักดี");
        Console.WriteLine("ที่อยู่:เขตปทุมวัน กรุงเทพมหานคร");
        Console.WriteLine("เบอร์ติดต่อ: 02-215-3555");
        Console.WriteLine();
        Console.WriteLine("มหาวิทยาลัยมหิดล");
        Console.WriteLine("ห้องสมุดรักโลก");
        Console.WriteLine("ที่อยู่: เขตศาลายา นครปฐม");
        Console.WriteLine("เบอร์ติดต่อ: 02-849-6211");
        Console.WriteLine();
        Console.WriteLine("สถาบันเทคโนโลยีพระจอมเกล้าเจ้าคุณทหารลาดกระบัง");
        Console.WriteLine("ห้องสมุดเกย์กีย์");
        Console.WriteLine("ที่อยู่:เขตลาดกระบัง กรุงเทพมหานคร");
        Console.WriteLine("เบอร์ติดต่อ: 02-329-8000");
        Console.WriteLine();
        Console.WriteLine("มหาวิทยาลัยขอนแก่น");
        Console.WriteLine("ห้องสมุดวัฒนะ");
        Console.WriteLine("ที่อยู่:เขตในเมือง ขอนแก่น");
        Console.WriteLine("เบอร์ติดต่อ: 043-002539");
        Console.WriteLine();
        Console.WriteLine("มหาวิทยาลัยเทคโนโลยีพระจอมเกล้าธนบุรี");
        Console.WriteLine("ห้องสมุดอาธร");
        Console.WriteLine("ที่อยู่:เขตทุ่งครุ กรุงเทพมหานคร");
        Console.WriteLine("เบอร์ติดต่อ: 02-470-8000");
    }

    public static void Agent(){
        Console.WriteLine("จุฬาลงกรณ์มหาวิทยาลัย");
        Console.WriteLine("ชื่อ: นายชัยดี");
        Console.WriteLine("นามสกุล: รักดี");
        Console.WriteLine("รหัสบัตรประชาชน: 153-698-4561237");
        Console.WriteLine();
        Console.WriteLine("มหาวิทยาลัยมหิดล");
        Console.WriteLine("ชื่อ: นายนอนดี");
        Console.WriteLine("นามสกุล: ใจดี");
        Console.WriteLine("รหัสบัตรประชาชน: 742-112-5687412");
        Console.WriteLine();
        Console.WriteLine("สถาบันเทคโนโลยีพระจอมเกล้าเจ้าคุณทหารลาดกระบัง");
        Console.WriteLine("ชื่อ: นายอภัยดี");
        Console.WriteLine("นามสกุล: เรียนดี");
        Console.WriteLine("รหัสบัตรประชาชน: 541-772-3215689");
        Console.WriteLine();
        Console.WriteLine("มหาวิทยาลัยขอนแก่น");
        Console.WriteLine("ชื่อ: นายทำดี");
        Console.WriteLine("นามสกุล: งานดี");
        Console.WriteLine("รหัสบัตรประชาชน: 153-698-4561237");
        Console.WriteLine();
        Console.WriteLine("มหาวิทยาลัยเทคโนโลยีพระจอมเกล้าธนบุรี");
        Console.WriteLine("ชื่อ: นายนอนดี");
        Console.WriteLine("นามสกุล: เรียบดี");
        Console.WriteLine("รหัสบัตรประชาชน: 003-852-4752000");
    }
    public static void FT(){
        Console.WriteLine("จุฬาลงกรณ์มหาวิทยาลัย");
        Console.WriteLine("ค่าของ FT = 10.2, 7.3, 8.4, 5.6, 9.3, 4.6, 1.2, 7.5, 8.2, 4.3, 6.0, 7.0");
        Console.WriteLine("มหาวิทยาลัยมหิดล");
        Console.WriteLine("ค่าของ FT = 9.2, 5.2, 8.9, 7.1, 9.3, 2.2, 1.7, 5.2, 9.1, 8.4, 2.1, 2.3");
        Console.WriteLine("สถาบันเทคโนโลยีพระจอมเกล้าเจ้าคุณทหารลาดกระบัง");
        Console.WriteLine("ค่าของ FT = 17.2, 19, 23, 25.1, 31, 32.1, 17.0, 14, 11.3, 18.1, 19.2, 22");
        Console.WriteLine("มหาวิทยาลัยขอนแก่น");
        Console.WriteLine("ค่าของ FT = 2.1, 2.0, 1.1, 1.5, 3.2, 4.1,2.2, 2.2, 1.3, 1.4, 5.0, 4.1");
        Console.WriteLine("มหาวิทยาลัยเทคโนโลยีพระจอมเกล้าธนบุรี");
        Console.WriteLine("ค่าของ FT = 17.2, 20, 23, 25.1, 31, 4.1, 17.0, 14, 11.3, 5.0, 19.2, 22");
        Console.WriteLine();
    }

}