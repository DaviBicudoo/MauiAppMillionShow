using MauiAppMillionShow.Models;

namespace MauiAppMillionShow
{
    public partial class App : Application
    {
        List<Question> easyQuestions = new()
        {
            new Question
            {
                Id = 1,
                Statement = "In which Brazilian state was presenter Xuxa born?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Rio de Janeiro"},
                    new Alternative {Correct = true,  Description = "Rio Grande do Sul"},
                    new Alternative {Correct = false,  Description = "Santa Catarina"},
                    new Alternative {Correct = false,  Description = "Goiás"}
                }
            },
            new Question
            {
                Id = 2,
                Statement = "What is the name given to the state of water in the form of ice?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Liquid"},
                    new Alternative {Correct = true,  Description = "Solid"},
                    new Alternative {Correct = false,  Description = "Gaseous"},
                    new Alternative {Correct = false,  Description = "Steamy"}
                }
            },
            new Question
            {
                Id = 3,
                Statement = "What was singer Elis Regina's nickname?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Gauchinha"},
                    new Alternative {Correct = false,  Description = "Paulistinha"},
                    new Alternative {Correct = true,  Description = "Pimentinha"},
                    new Alternative {Correct = false,  Description = "Andorinha"}
                }
            },
            new Question
            {
                Id = 4,
                Statement = "Who is Mickey's girlfriend?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Margarida"},
                    new Alternative {Correct = true,  Description = "Minnie"},
                    new Alternative {Correct = false,  Description = "The little mermaid"},
                    new Alternative {Correct = false,  Description = "Olivia Palito"}
                }
            },
            new Question
            {
                Id = 5,
                Statement = "Which Brazilian folklore character has only one leg?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Cuca"},
                    new Alternative {Correct = false,  Description = "Negrinho do pastoreio"},
                    new Alternative {Correct = false,  Description = "Boitatá"},
                    new Alternative {Correct = true,  Description = "Saci-Pererê"}
                }
            },
            new Question
            {
                Id = 6,
                Statement = "Which country was Fidel Castro born in?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Jamaica"},
                    new Alternative {Correct = true,  Description = "Cuba"},
                    new Alternative {Correct = false,  Description = "El Salvador"},
                    new Alternative {Correct = false,  Description = "Mexico"}
                }
            },
            new Question
            {
                Id = 7,
                Statement = "Who proclaimed the republic in Brazil in 1889?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Duque de Caxias"},
                    new Alternative {Correct = false,  Description = "Marechal Rondon"},
                    new Alternative {Correct = false,  Description = "Dom Pedro II"},
                    new Alternative {Correct = true,  Description = "Marechal Deodoro"}
                }
            },
            new Question
            {
                Id = 8,
                Statement = "Who is the patron of the Brazilian army?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Marechal Deodoro"},
                    new Alternative {Correct = false,  Description = "Barão de Maua"},
                    new Alternative {Correct = true,  Description = "Duque de Caxias"},
                    new Alternative {Correct = false,  Description = "Marquês de Pombal"}
                }
            },
            new Question
            {
                Id = 9,
                Statement = "Who was the presenter who reproached the freshmen by blowing a horn?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Raul Gil"},
                    new Alternative {Correct = false,  Description = "Bolinha"},
                    new Alternative {Correct = false,  Description = "Flávio Cavalcanti"},
                    new Alternative {Correct = true,  Description = "Chacrinha"}
                }
            },
            new Question
            {
                Id = 10,
                Statement = "What was Mary Shelley's Frankenstein?",
                Alternatives = new()
                {
                    new Alternative {Correct = true,  Description = "Monster"},
                    new Alternative {Correct = false,  Description = "Gorila"},
                    new Alternative {Correct = false,  Description = "Príncipe"},
                    new Alternative {Correct = false,  Description = "Sapo"}
                }
            },
            new Question
            {
                Id = 11,
                Statement = "What is the zodiac sign of someone born on New Year's Day?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Virgem"},
                    new Alternative {Correct = false,  Description = "Capricórnio"},
                    new Alternative {Correct = true,  Description = "Aquário"},
                    new Alternative {Correct = false,  Description = "Ares"}
                }
            },
            new Question
            {
                Id = 12,
                Statement = "Who founded the Ford car factory?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Harrison Ford"},
                    new Alternative {Correct = false,  Description = "Gerald Ford"},
                    new Alternative {Correct = true,  Description = "Henry Ford"},
                    new Alternative {Correct = false,  Description = "Anna Ford"}
                }
            },
            new Question
            {
                Id = 13,
                Statement = "What color is associated with ecological groups?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Blue"},
                    new Alternative {Correct = false,  Description = "Red"},
                    new Alternative {Correct = false,  Description = "Yellow"},
                    new Alternative {Correct = true,  Description = "Green"}
                }
            },
            new Question
            {
                Id = 14,
                Statement = "How many degrees centigrade does the water boil at?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "50º"},
                    new Alternative {Correct = false,  Description = "75º"},
                    new Alternative {Correct = false,  Description = "25º"},
                    new Alternative {Correct = true,  Description = "100º"}
                }
            },
            new Question
            {
                Id = 15,
                Statement = "Quando é comemorado o dia da independência do Brasil?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "On 21 April"},
                    new Alternative {Correct = false,  Description = "On 12 October"},
                    new Alternative {Correct = true,  Description = "On 7 September"},
                    new Alternative {Correct = false,  Description = "On 25 December"}
                }
            },
        };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
