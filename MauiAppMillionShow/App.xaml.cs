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
            new Question
            {
                Id = 16,
                Statement = "Which place is also called the Holy See?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Veneza"},
                    new Alternative {Correct = false,  Description = "Vitória"},
                    new Alternative {Correct = false,  Description = "Vancouver"},
                    new Alternative {Correct = true,  Description = "Vaticano"}
                }
            },
            new Question
            {
                Id = 17,
                Statement = "Who has the motto: Always on the alert?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Médicos"},
                    new Alternative {Correct = true,  Description = "Escoteiros"},
                    new Alternative {Correct = false,  Description = "Bombeiros"},
                    new Alternative {Correct = false,  Description = "Policiais"}
                }
            },
            new Question
            {
                Id = 18,
                Statement = "Who was Julieta's great love?",
                Alternatives = new()
                {
                    new Alternative {Correct = true,  Description = "Romeu"},
                    new Alternative {Correct = false,  Description = "Orfeu"},
                    new Alternative {Correct = false,  Description = "Hamlet"},
                    new Alternative {Correct = false,  Description = "Iago"}
                }
            },
            new Question
            {
                Id = 19,
                Statement = "How many signs make up the zodiac?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Nine"},
                    new Alternative {Correct = false,  Description = "Ten"},
                    new Alternative {Correct = false,  Description = "Eleven"},
                    new Alternative {Correct = true,  Description = "Twelve"}
                }
            },
            new Question
            {
                Id = 20,
                Statement = "Vatapá is a typical food of which state?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Paraná"},
                    new Alternative {Correct = false,  Description = "Santa Catarina"},
                    new Alternative {Correct = false,  Description = "São Paulo"},
                    new Alternative {Correct = true,  Description = "Bahia"}
                }
            },
            new Question
            { 
                Id = 21,
                Statement = "What is the name of the part where the bullets are stored in a revolver?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Cano"},
                    new Alternative {Correct = true,  Description = "Tambor"},
                    new Alternative {Correct = false, Description = "Agulha"},
                    new Alternative {Correct = false, Description = "Gatilho"}
                }
            },
            new Question
            {
                Id = 22,
                Statement = "Which character from the 'Turma da Mônica' has only five hairs?",
                Alternatives = new()
                {
                    new Alternative {Correct = false,  Description = "Mônica"},
                    new Alternative {Correct = true, Description = "Cebolinha"},
                    new Alternative {Correct = false, Description = "Cascão"},
                    new Alternative {Correct = false, Description = "Magali"}
                }
            },
            new Question
            {
                Id = 23,
                Statement = "Which singer was nicknamed 'Ternurinha' during the Young Guard era?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Silvinha"},
                    new Alternative {Correct = true,  Description = "Wanderléia"},
                    new Alternative {Correct = false, Description = "Gretchen"},
                    new Alternative {Correct = false, Description = "Martinha"}
                }
            },
            new Question
            {
                Id = 24,
                Statement = "Barbecue is considered a typical food of which state?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Ceará"},
                    new Alternative {Correct = true,  Description = "Rio Grande do Sul"},
                    new Alternative {Correct = false, Description = "Pará"},
                    new Alternative {Correct = false, Description = "Maranhão"}
                }
            },
            new Question
            {
                Id = 25,
                Statement = "Which singer is the father of the duo Sandy and Júnior?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Leonardo"},
                    new Alternative {Correct = true,  Description = "Xororó"},
                    new Alternative {Correct = false, Description = "Zezé Di Camargo"},
                    new Alternative {Correct = false, Description = "Chitãozinho"}
                }
            },
            new Question
            {
                Id = 26,
                Statement = "Who created the characters Pedrinho, Narizinho, and Emília?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Maurício de Sousa"},
                    new Alternative {Correct = false, Description = "Ziraldo"},
                    new Alternative {Correct = true,  Description = "Monteiro Lobato"},
                    new Alternative {Correct = false, Description = "Machado de Assis"}
                }
            },
            new Question
            {
                Id = 27,
                Statement = "Who founded Microsoft?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Sultão de Brunei"},
                    new Alternative {Correct = false, Description = "Akio Morita"},
                    new Alternative {Correct = true,  Description = "Bill Gates"},
                    new Alternative {Correct = false, Description = "Príncipe Charles"}
                }
            },
            new Question
            {
                Id = 28,
                Statement = "What is the name given to a car's spare tire?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Calota"},
                    new Alternative {Correct = true,  Description = "Estepe"},
                    new Alternative {Correct = false, Description = "Macaco"},
                    new Alternative {Correct = false, Description = "Chave de roda"}
                }
            },
            new Question
            {
                Id = 29,
                Statement = "What is the name of the cowardly dog of Salsicha from the cartoons?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Floquinho"},
                    new Alternative {Correct = false, Description = "Rin-Tin-Tin"},
                    new Alternative {Correct = false, Description = "Lassie"},
                    new Alternative {Correct = true,  Description = "Scooby-Doo"}
                }
            },
            new Question
            {
                Id = 30,
                Statement = "How many sets of natural teeth does a human have during their lifetime?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "One"},
                    new Alternative {Correct = true,  Description = "Two"},
                    new Alternative {Correct = false, Description = "Three"},
                    new Alternative {Correct = false, Description = "Four"}
                }
            },
            new Question
            {
                Id = 31,
                Statement = "In which position did Edinho, Pelé's son, play for Santos?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Zagueiro"},
                    new Alternative {Correct = true,  Description = "Goleiro"},
                    new Alternative {Correct = false, Description = "Atacante"},
                    new Alternative {Correct = false, Description = "Armador"}
                }
            },
            new Question
            {
                Id = 32,
                Statement = "What is the hardest precious stone found in nature?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Esmeralda"},
                    new Alternative {Correct = false, Description = "Rubi"},
                    new Alternative {Correct = false, Description = "Pérola"},
                    new Alternative {Correct = true,  Description = "Diamante"}
                }
            },
            new Question
            {
                Id = 33,
                Statement = "What is the name of the place where wines are stored?",
                Alternatives = new()
                {
                    new Alternative {Correct = true,  Description = "Adega"},
                    new Alternative {Correct = false, Description = "Biblioteca"},
                    new Alternative {Correct = false, Description = "Sóton"},
                    new Alternative {Correct = false, Description = "Sala"}
                }
            },
            new Question
            {
                Id = 34,
                Statement = "Which singer is known as 'the king of rock'?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Frank Sinatra"},
                    new Alternative {Correct = false, Description = "Little Richard"},
                    new Alternative {Correct = true,  Description = "Elvis Presley"},
                    new Alternative {Correct = false, Description = "Richie Valens"}
                }
            },
            new Question
            {
                Id = 35,
                Statement = "Who is Piu-Piu's enemy in the cartoons?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Félix"},
                    new Alternative {Correct = false, Description = "Tom"},
                    new Alternative {Correct = true,  Description = "Frajola"},
                    new Alternative {Correct = false, Description = "Mingau"}
                }
            },
            new Question
            {
                Id = 36,
                Statement = "Joana Prado is the real name of which artist?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Tiazinha"},
                    new Alternative {Correct = true,  Description = "Feiticeira"},
                    new Alternative {Correct = false, Description = "Lady Lu"},
                    new Alternative {Correct = false, Description = "Sheila Mello"}
                }
            },
            new Question
            {
                Id = 37,
                Statement = "How many days are there in a leap year?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "364"},
                    new Alternative {Correct = false, Description = "365"},
                    new Alternative {Correct = true,  Description = "366"},
                    new Alternative {Correct = false, Description = "367"}
                }
            },
            new Question
            {
                Id = 38,
                Statement = "Which reptile changes color depending on its environment?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Sapo"},
                    new Alternative {Correct = true,  Description = "Camaleão"},
                    new Alternative {Correct = false, Description = "Lagarto"},
                    new Alternative {Correct = false, Description = "Jacaré"}
                }
            },
            new Question
            {
                Id = 39,
                Statement = "What is the duration of each half in a football match?",
                Alternatives = new()
                {
                    new Alternative {Correct = true,  Description = "45 minutes"},
                    new Alternative {Correct = false, Description = "90 minutes"},
                    new Alternative {Correct = false, Description = "120 minutes"},
                    new Alternative {Correct = false, Description = "150 minutes"}
                }
            },
            new Question
            {
                Id = 40,
                Statement = "Where is the center of the film industry in the USA?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "New York"},
                    new Alternative {Correct = false, Description = "Las Vegas"},
                    new Alternative {Correct = false, Description = "New Orleans"},
                    new Alternative {Correct = true,  Description = "Hollywood"}
                }
            }
        };

        List<Question> mediumQuestions = new()
        {
            new Question
            {
                Id = 41,
                Statement = "Who directed the movie 'Central do Brasil'?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Bruno Barreto"},
                    new Alternative {Correct = false, Description = "Héctor Babenco"},
                    new Alternative {Correct = false, Description = "Arnaldo Jabor"},
                    new Alternative {Correct = true, Description = "Walter Salles Júnior"}
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
