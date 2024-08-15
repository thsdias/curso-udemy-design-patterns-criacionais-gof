﻿using System;
using System.Collections.Generic;

namespace FluentBuilder2
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new Email
            {
                To = "microsoft@hotmail.com",
                From = "macoratti@yahoo.com",
                Subject = "MVP",
                Body = "MVP Award"
            };

            var builder = new ConcreteEmail(email);
            var director = new EmailDirector(builder);

            director.ConstroiEmail();

            var emailReport = builder.GetEmail();
            Console.WriteLine(emailReport);

            Console.ReadLine();
        }
    }
}
