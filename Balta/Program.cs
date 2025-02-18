﻿using System;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta
{
  class Program 
  {
    static void Main(string[] args)
    {
      /* var course = new Course();
      course.Level = ContentContext.Enums.EContentLevel.Beginner;
      foreach (var item in course.Modules) 
      {

      }
      var career = new Career();
      career.Items.Add(new CareerItem());
      Console.WriteLine(career.TotalCourses); */

      var articles = new List<Article>();
      articles.Add(new Article("Artigo OOP", "orientacao-objeto"));
      articles.Add(new Article("Artigo C#", "csharp"));
      articles.Add(new Article("Artigo .NET", "dotnet"));
      
      /* foreach (var article in articles)
      {
        Console.WriteLine(article.Id);
        Console.WriteLine(article.Title);
        Console.WriteLine(article.Url);
      } */
      var courses = new List<Course>();
      var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
      var courseCsharp = new Course("Fundamentos C#", "fundamentos-C#");
      var coursesAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

      courses.Add(courseOOP);
      courses.Add(courseCsharp);
      courses.Add(coursesAspNet);

    
      var careers =new List<Career>();
      var careerDotnet = new Career("Especialista .NET","especialista-dotnet");
      var careerItem2 = new CareerItem(2,"Aprenda OOP", "",null);
      var careerItem = new CareerItem(1,"Comece por aqui", "",courseCsharp);
      var careerItem3 = new CareerItem(3,"Aprenda .Net", "",coursesAspNet);
      
      careerDotnet.Items.Add(careerItem2);
      careerDotnet.Items.Add(careerItem);
      careerDotnet.Items.Add(careerItem3);
      careers.Add(careerDotnet);
      
      foreach (var career in careers)
      {
       Console.WriteLine(career.Title);
        foreach (var item in career.Items.OrderBy(x => x.Order))
        {
          Console.WriteLine($" {item.Order} - {item.Title}");
          Console.WriteLine(item.Course?.Title);
          Console.WriteLine(item.Course?.Level);

          foreach (var notification in item.Notifications)
          {
              Console.WriteLine($"{notification.Property} - {notification.Message}");
          }
        }
        var payPalSubscription = new PayPalSubscription();
        var student = new Student();
        student.CreateSubscription(payPalSubscription);
      }
    }
  }
}	