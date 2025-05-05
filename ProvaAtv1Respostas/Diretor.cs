using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Director
    {
        public void NotificationNormalb(IBuilder builder)
        {
            builder.Reset();
            builder.SetDestinatario("Terra");
            builder.SetCorpo("Olá Mundo!");           
        }
        public void NotificationCompleteb(IBuilder builder)
        {
            builder.Reset();
            builder.SetDestinatario("Earth");
            builder.SetTitulo("Hello Earth World");
            builder.SetCorpo("Hello Earth World! First Hello World! First Hello Earth!");
            builder.SetAssunto("Earth Hi");
            builder.SetRemetente("Earth");
            builder.SetAnexo("Earth.png");
            builder.SetPrioridade("Great");
        }
    }