namespace HelloWorld.Models{
    public class Computer{

   public String Motherboard {get; set;}
   public int CPUCore{get; set;}
   public bool HasWifi{get; set;}
   public bool HasLTE{get; set;}
   public DateTime ReleaseDate{get; set;}
   public Decimal price{get; set;}
   public String VideoCard{get; set;}

    public Computer(){
        if(VideoCard == null){

            VideoCard = "";
        } 
        if(Motherboard == null){

            Motherboard = "";
        } 
}
}
}