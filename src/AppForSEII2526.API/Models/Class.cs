namespace AppForSEII2526.API.Models
{
    public class Class
    {
        private string att { get; set; }
        public Class(){
            Console.WriteLine("Class instantiated");//Comentario añadido
        }

        public string Attribute{
            get{ return att; }
            set { att = value; }
        }
      
        public string Method(){
            return "Method executed";
        }

    }
}
