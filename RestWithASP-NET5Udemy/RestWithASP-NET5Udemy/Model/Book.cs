using RestWithASP_NET5Udemy.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASP_NET5Udemy.Model
{

    [Table("books")]
    public class Book : BaseEntity
    {

        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }

    }



        /*[Table("books")]
        public class Book
        {
            [Column("id")]
            public long Id { get; set; }
            [Column("title")]
            public string Title { get; set; }

            [Column("author")]
            public string Author { get; set; }

            [Column("price")]
            public decimal Price { get; set; }

            [Column("launch_date")]
            public DateTime LaunchDate { get; set; }

        }*/
    }
/*CREATE TABLE books (
  id  BIGINT NOT NULL IDENTITY(1,1) PRIMARY KEY,
  author varchar(100) NOT NULL,
  launch_date datetime NOT NULL,
  price decimal(38,2) NOT NULL,
  title varchar(100)
) 



INSERT INTO books (author, launch_date, price, title) VALUES ('Michael C. Feathers', '20171129 3:50:05 PM', 49.00, 'Working effectively with legacy code'),
	('Ralph Johnson, Erich Gamma, John Vlissides e Richard Helm', '20171129 3:15:13 PM', 45.00, 'Design Patterns'),
	('Robert C. Martin', '20090110 3:00:00 PM', 77.00, 'Clean Code'),
	('Crockford', '20171107 3:09:01 PM', 67.00, 'JavaScript'),
	('Steve McConnell', '20171107 3:09:01 PM', 58.00, 'Code complete'),
	('Martin Fowler e Kent Beck', '20171107 3:09:01 PM', 88.00, 'Refactoring'),
	('Eric Freeman, Elisabeth Freeman, Kathy Sierra, Bert Bates', '20171107 3:09:01 PM', 110.00, 'Head First Design Patterns'),
	('Eric Evans', '20171107 3:09:01 PM', 92.00, 'Domain Driven Design'),
	('Brian Goetz e Tim Peierls', '20171107 3:09:01 PM', 80.00, 'Java Concurrency in Practice'),
	('Susan Cain', '20171107 3:09:01 PM', 123.00, 'O poder dos quietos'),
	('Roger S. Pressman', '20171107 3:09:01 PM', 56.00, 'Engenharia de Software: uma abordagem profissional'),
	('Viktor Mayer-Schonberger e Kenneth Kukier', '20171107 3:09:01 PM', 54.00, 'Big Data: como extrair volume, variedade, velocidade e valor da avalanche de informação cotidiana'),
	('Richard Hunter e George Westerman', '20171107 3:09:01 PM', 95.00, 'O verdadeiro valor de TI'),
	('Marc J. Schiller', '20171107 3:09:01 PM', 45.00, 'Os 11 segredos de líderes de TI altamente influentes'),
	('Aguinaldo Aragon Fernandes e Vladimir Ferraz de Abreu', '20171107 3:09:01 PM', 54.00, 'Implantando a governança de TI');*/