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
            new Question
            {
                Id = 42,
                Statement = "What does the term e-mail mean?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Quick Mail"},
                    new Alternative {Correct = true, Description = "Electronic Mail"},
                    new Alternative {Correct = false, Description = "Elegant Mail"},
                    new Alternative {Correct = false, Description = "Machine Mail"}
                }
            },
            new Question
            {
                Id = 43,
                Statement = "Camillo is the last name of which singer born in Brotas?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Leonardo"},
                    new Alternative {Correct = false, Description = "Chitãozinho"},
                    new Alternative {Correct = true, Description = "Daniel"},
                    new Alternative {Correct = false, Description = "Vinny"}
                }
            },
            new Question
            {
                Id = 44,
                Statement = "How many members did the Beatles have?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Three"},
                    new Alternative {Correct = true, Description = "Four"},
                    new Alternative {Correct = false, Description = "Five"},
                    new Alternative {Correct = false, Description = "Six"}
                }
            },
            new Question
            {
                Id = 45,
                Statement = "Who was the last emperor of Brazil?",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "D. Pedro II"},
                    new Alternative {Correct = false, Description = "D. Pedro I"},
                    new Alternative {Correct = false, Description = "D. João VI"},
                    new Alternative {Correct = false, Description = "Deodoro da Fonseca"}
                }
            },
            new Question
            {
                Id = 46,
                Statement = "What is the chemical formula of water?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "NaCl"},
                    new Alternative {Correct = false, Description = "H2"},
                    new Alternative {Correct = true, Description = "H2O"},
                    new Alternative {Correct = false, Description = "CO2"}
                }
            },
            new Question
            {
                Id = 47,
                Statement = "What was Cecília Meirelles' profession?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Singer"},
                    new Alternative {Correct = true, Description = "Writer"},
                    new Alternative {Correct = false, Description = "Architect"},
                    new Alternative {Correct = false, Description = "Pianist"}
                }
            },
            new Question
            {
                Id = 48,
                Statement = "In which city is the headquarters of the BBC located?",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "London"},
                    new Alternative {Correct = false, Description = "New York"},
                    new Alternative {Correct = false, Description = "Montreal"},
                    new Alternative {Correct = false, Description = "California"}
                }
            },
            new Question
            {
                Id = 49,
                Statement = "What is the capital of the state of Mato Grosso do Sul?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Cuiabá"},
                    new Alternative {Correct = false, Description = "Várzea Grande"},
                    new Alternative {Correct = false, Description = "Rondonópolis"},
                    new Alternative {Correct = true, Description = "Campo Grande"}
                }
            },
            new Question
            {
                Id = 50,
                Statement = "How many continents are there?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Five"},
                    new Alternative {Correct = true, Description = "Seven"},
                    new Alternative {Correct = false, Description = "Three"},
                    new Alternative {Correct = false, Description = "Four"}
                }
            },
            new Question
            {
                Id = 51,
                Statement = "What are people from the Arctic known as?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Southerners"},
                    new Alternative {Correct = true, Description = "Eskimos"},
                    new Alternative {Correct = false, Description = "Northerners"},
                    new Alternative {Correct = false, Description = "Polar people"}
                }
            },
            new Question
            {
                Id = 52,
                Statement = "Which Japanese city was the first to be bombed with an atomic bomb?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Tokyo"},
                    new Alternative {Correct = false, Description = "Nagasaki"},
                    new Alternative {Correct = false, Description = "Osaka"},
                    new Alternative {Correct = true, Description = "Hiroshima"}
                }
            },
            new Question
            {
                Id = 53,
                Statement = "What is a colorblind person deficient in?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Feeling pain"},
                    new Alternative {Correct = false, Description = "Feeling taste"},
                    new Alternative {Correct = true, Description = "Differentiating colors"},
                    new Alternative {Correct = false, Description = "Feeling smell"}
                }
            },
            new Question
            {
                Id = 54,
                Statement = "What is the day of the Patroness of Brazil?",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "October 12"},
                    new Alternative {Correct = false, Description = "November 12"},
                    new Alternative {Correct = false, Description = "December 11"},
                    new Alternative {Correct = false, Description = "January 1"}
                }
            },
            new Question
            {
                Id = 55,
                Statement = "What animal is used in polo?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Camel"},
                    new Alternative {Correct = true, Description = "Horse"},
                    new Alternative {Correct = false, Description = "Monkey"},
                    new Alternative {Correct = false, Description = "Dog"}
                }
            },
            new Question
            {
                Id = 56,
                Statement = "In which year did the Joelma building fire occur in São Paulo?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "1971"},
                    new Alternative {Correct = false, Description = "1972"},
                    new Alternative {Correct = false, Description = "1973"},
                    new Alternative {Correct = true, Description = "1974"}
                }
            },
            new Question
            {
                Id = 57,
                Statement = "Teresina is the capital of which Brazilian state?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Tocantins"},
                    new Alternative {Correct = true, Description = "Piauí"},
                    new Alternative {Correct = false, Description = "Acre"},
                    new Alternative {Correct = false, Description = "Paraná"}
                }
            },
            new Question
            {
                Id = 58,
                Statement = "What does the acronym 'AI' stand for in AI-5?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Intentional Act"},
                    new Alternative {Correct = true, Description = "Institutional Act"},
                    new Alternative {Correct = false, Description = "Inspirational Act"},
                    new Alternative {Correct = false, Description = "Idealizing Act"}
                }
            },
            new Question
            {
                Id = 59,
                Statement = "Which biblical character parted the waters of the Red Sea?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Abraham"},
                    new Alternative {Correct = true, Description = "Moses"},
                    new Alternative {Correct = false, Description = "Joshua"},
                    new Alternative {Correct = false, Description = "Elijah"}
                }
            },
            new Question
            {
                Id = 60,
                Statement = "Which of these snakes is not venomous?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Urutu"},
                    new Alternative {Correct = false, Description = "Rattlesnake"},
                    new Alternative {Correct = false, Description = "Jaracaca"},
                    new Alternative {Correct = true, Description = "Python"}
                }
            },
            new Question
            {
                Id = 61,
                Statement = "What is the name of the Patriarch of Brazil's Independence?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Tiradentes"},
                    new Alternative {Correct = true, Description = "José Bonifácio"},
                    new Alternative {Correct = false, Description = "Dom Pedro II"},
                    new Alternative {Correct = false, Description = "Vasco da Gama"}
                }
            },
            new Question
            {
                Id = 62,
                Statement = "The name America was associated with which of these names?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Américo dos Reis"},
                    new Alternative {Correct = false, Description = "Américo Brasilienses"},
                    new Alternative {Correct = true, Description = "Américo Vespúcio"},
                    new Alternative {Correct = false, Description = "José Américo da Silva"}
                }
            },
            new Question
            {
                Id = 63,
                Statement = "Which doctor most commonly uses the electrocardiogram?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Orthopedist"},
                    new Alternative {Correct = true, Description = "Cardiologist"},
                    new Alternative {Correct = false, Description = "Dermatologist"},
                    new Alternative {Correct = false, Description = "Acupuncturist"}
                }
            },
            new Question
            {
                Id = 64,
                Statement = "In which Brazilian city is the Instituto Tecnológico de Aeronáutica located?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "São José do Rio Preto"},
                    new Alternative {Correct = false, Description = "São José dos Pinhais"},
                    new Alternative {Correct = true, Description = "São José dos Campos"},
                    new Alternative {Correct = false, Description = "São José dos Santos"}
                }
            },
            new Question
            {
                Id = 65,
                Statement = "In which city were the 2000 Olympic Games held?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Munich"},
                    new Alternative {Correct = true, Description = "Sydney"},
                    new Alternative {Correct = false, Description = "Tokyo"},
                    new Alternative {Correct = false, Description = "Atlanta"}
                }
            },
            new Question
            {
                Id = 66,
                Statement = "In which country is the Great Wall with approximately 6,400 kilometers located?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Japan"},
                    new Alternative {Correct = true, Description = "China"},
                    new Alternative {Correct = false, Description = "Afghanistan"},
                    new Alternative {Correct = false, Description = "India"}
                }
            },
            new Question
            {
                Id = 67,
                Statement = "What is the sacred temple of the Jews called?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Church"},
                    new Alternative {Correct = false, Description = "Chapel"},
                    new Alternative {Correct = true, Description = "Synagogue"},
                    new Alternative {Correct = false, Description = "Cathedral"}
                }
            },
            new Question
            {
                Id = 68,
                Statement = "To which category does the seahorse belong?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Mollusk"},
                    new Alternative {Correct = false, Description = "Crustacean"},
                    new Alternative {Correct = true, Description = "Fish"},
                    new Alternative {Correct = false, Description = "Mammal"}
                }
            },
            new Question
            {
                Id = 69,
                Statement = "Which country has the FBI as its federal police?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "England"},
                    new Alternative {Correct = true, Description = "United States"},
                    new Alternative {Correct = false, Description = "Canada"},
                    new Alternative {Correct = false, Description = "France"}
                }
            },
            new Question
            {
                Id = 70,
                Statement = "In 1991, which American athlete retired from basketball due to being HIV positive?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Michael Jordan"},
                    new Alternative {Correct = true, Description = "Magic Johnson"},
                    new Alternative {Correct = false, Description = "Dennis Rodman"},
                    new Alternative {Correct = false, Description = "Mike Tyson"}
                }
            },
            new Question
            {
                Id = 71,
                Statement = "What is the name of Charlie Brown's dog?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Pluto"},
                    new Alternative {Correct = false, Description = "Floquinho"},
                    new Alternative {Correct = false, Description = "Baleia"},
                    new Alternative {Correct = true, Description = "Snoopy"}
                }
            },
            new Question
            {
                Id = 72,
                Statement = "Which U.S. president was a movie actor?",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "Ronald Reagan"},
                    new Alternative {Correct = false, Description = "George Bush"},
                    new Alternative {Correct = false, Description = "Richard Nixon"},
                    new Alternative {Correct = false, Description = "Bill Clinton"}
                }
            },
            new Question
            {
                Id = 73,
                Statement = "In which U.S. state is the city of Miami located?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Alaska"},
                    new Alternative {Correct = false, Description = "New York"},
                    new Alternative {Correct = true, Description = "Florida"},
                    new Alternative {Correct = false, Description = "California"}
                }
            },
            new Question
            {
                Id = 74,
                Statement = "What is the capital of Iraq?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Belém"},
                    new Alternative {Correct = true, Description = "Baghdad"},
                    new Alternative {Correct = false, Description = "Beirut"},
                    new Alternative {Correct = false, Description = "Budapest"}
                }
            },
            new Question
            {
                Id = 75,
                Statement = "What is the name of the machine used to compact asphalt?",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "Road Roller"},
                    new Alternative {Correct = false, Description = "Excavator"},
                    new Alternative {Correct = false, Description = "Tractor"},
                    new Alternative {Correct = false, Description = "Sander"}
                }
            },
            new Question
            {
                Id = 76,
                Statement = "By the banks of which stream was Brazil's Independence proclaimed?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Cambuci"},
                    new Alternative {Correct = false, Description = "Sacomã"},
                    new Alternative {Correct = true, Description = "Ipiranga"},
                    new Alternative {Correct = false, Description = "São Francisco"}
                }
            },
            new Question
            {
                Id = 77,
                Statement = "What sport is the 'Super Bowl' part of?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Baseball"},
                    new Alternative {Correct = false, Description = "Basketball"},
                    new Alternative {Correct = true, Description = "American Football"},
                    new Alternative {Correct = false, Description = "Golf"}
                }
            },
            new Question
            {
                Id = 78,
                Statement = "What is the name of the typical boat from the northeastern coast of Brazil?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Submarine"},
                    new Alternative {Correct = false, Description = "Jet Ski"},
                    new Alternative {Correct = true, Description = "Jangada"},
                    new Alternative {Correct = false, Description = "Boat"}
                }
            },
            new Question
            {
                Id = 79,
                Statement = "Beirut is the capital of which country?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Syria"},
                    new Alternative {Correct = false, Description = "Nepal"},
                    new Alternative {Correct = false, Description = "Mongolia"},
                    new Alternative {Correct = true, Description = "Lebanon"}
                }
            },
            new Question
            {
                Id = 80,
                Statement = "What is a destroyer?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Tank"},
                    new Alternative {Correct = true, Description = "Warship"},
                    new Alternative {Correct = false, Description = "Dirigible"},
                    new Alternative {Correct = false, Description = "Fighter Jet"}
                }
            },

        };

        List<Question> hardQuestions = new()
        {
            new Question
            {
                Id = 81,
                Statement = "How did the French king Louis XVI and his wife Marie Antoinette die?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Executed"},
                    new Alternative {Correct = false, Description = "Shot"},
                    new Alternative {Correct = true, Description = "Guillotined"},
                    new Alternative {Correct = false, Description = "Burned"}
                }
            },
            new Question
            {
                Id = 82,
                Statement = "What is the term for a print made on wooden boards?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Materography"},
                    new Alternative {Correct = false, Description = "Lithography"},
                    new Alternative {Correct = true, Description = "Woodcut"},
                    new Alternative {Correct = false, Description = "Screen Printing"}
                }
            },
            new Question
            {
                Id = 83,
                Statement = "What did the painter Claude Monet represent in his paintings?",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "The Gardens of Giverny"},
                    new Alternative {Correct = false, Description = "Paris Bistros"},
                    new Alternative {Correct = false, Description = "Scenes from the Moulin Rouge"},
                    new Alternative {Correct = false, Description = "Provence Landscapes"}
                }
            },
            new Question
            {
                Id = 84,
                Statement = "Miró, Picasso, and Salvador Dalí were painters from which country?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Italian"},
                    new Alternative {Correct = false, Description = "Portuguese"},
                    new Alternative {Correct = true, Description = "Spanish"},
                    new Alternative {Correct = false, Description = "Chilean"}
                }
            },
            new Question
            {
                Id = 85,
                Statement = "Which Formula 1 driver won the World Championship title five times?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Jacques Stewart"},
                    new Alternative {Correct = false, Description = "Alain Prost"},
                    new Alternative {Correct = true, Description = "Ayrton Senna"},
                    new Alternative {Correct = false, Description = "Juan Manuel Fangio"}
                }
            },
            new Question
            {
                Id = 86,
                Statement = "What is the largest island in Europe?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Great Britain"},
                    new Alternative {Correct = false, Description = "Ireland"},
                    new Alternative {Correct = true, Description = "Iceland"},
                    new Alternative {Correct = false, Description = "Sicily"}
                }
            },
            new Question
            {
                Id = 87,
                Statement = "The film 'The Sound of Music,' awarded 5 Oscars, starred:",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Judy Garland"},
                    new Alternative {Correct = false, Description = "Shirley Temple"},
                    new Alternative {Correct = true, Description = "Julie Andrews"},
                    new Alternative {Correct = false, Description = "Doris Day"}
                }
            },
            new Question
            {
                Id = 88,
                Statement = "Who was the first president of Brazil elected by the people?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Getúlio Vargas"},
                    new Alternative {Correct = true, Description = "Prudente de Morais"},
                    new Alternative {Correct = false, Description = "Washington Luís"},
                    new Alternative {Correct = false, Description = "Tancredo Neves"}
                }
            },
            new Question
            {
                Id = 89,
                Statement = "What is the term for an explorer of caves and caverns?",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "Speleologist"},
                    new Alternative {Correct = false, Description = "Agrologist"},
                    new Alternative {Correct = false, Description = "Psychologist"},
                    new Alternative {Correct = false, Description = "Campanologist"}
                }
            },
            new Question
            {
                Id = 90,
                Statement = "What is the most used transportation system in Brazil?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Railway"},
                    new Alternative {Correct = false, Description = "Air"},
                    new Alternative {Correct = false, Description = "Waterway"},
                    new Alternative {Correct = true, Description = "Road"}
                }
            },
            new Question
            {
                Id = 91,
                Statement = "The whale is classified under which group of mammals?",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "Cetaceans"},
                    new Alternative {Correct = false, Description = "Felids"},
                    new Alternative {Correct = false, Description = "Sirenids"},
                    new Alternative {Correct = false, Description = "Carnivores"}
                }
            },
            new Question
            {
                Id = 92,
                Statement = "In which country did Leonardo da Vinci spend his final days?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Spain"},
                    new Alternative {Correct = false, Description = "Netherlands"},
                    new Alternative {Correct = true, Description = "France"},
                    new Alternative {Correct = false, Description = "Italy"}
                }
            },
            new Question
            {
                Id = 93,
                Statement = "Which country does Greenland belong to?",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "Denmark"},
                    new Alternative {Correct = false, Description = "England"},
                    new Alternative {Correct = false, Description = "Norway"},
                    new Alternative {Correct = false, Description = "United States"}
                }
            },
            new Question
            {
                Id = 94,
                Statement = "Pablo Picasso was one of the creators of:",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "Cubism"},
                    new Alternative {Correct = false, Description = "Surrealism"},
                    new Alternative {Correct = false, Description = "Impressionism"},
                    new Alternative {Correct = false, Description = "Realism"}
                }
            },
            new Question
            {
                Id = 95,
                Statement = "What was Juan Ponce de León searching for when he discovered Florida?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "The Lost City of Gold"},
                    new Alternative {Correct = true, Description = "The Fountain of Youth"},
                    new Alternative {Correct = false, Description = "Unicorns"},
                    new Alternative {Correct = false, Description = "His Cat"}
                }
            },
            new Question
            {
                Id = 96,
                Statement = "The Falkland Islands are also called:",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Stanley"},
                    new Alternative {Correct = false, Description = "Weddells"},
                    new Alternative {Correct = false, Description = "Medanosa"},
                    new Alternative {Correct = true, Description = "Falkland"}
                }
            },
            new Question
            {
                Id = 97,
                Statement = "Which of these countries is not located on the Equator?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Kenya"},
                    new Alternative {Correct = false, Description = "Ecuador"},
                    new Alternative {Correct = true, Description = "Chile"},
                    new Alternative {Correct = false, Description = "Indonesia"}
                }
            },
            new Question
            {
                Id = 98,
                Statement = "Who was the first woman inducted into the Rock and Roll Hall of Fame?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Janis Joplin"},
                    new Alternative {Correct = false, Description = "Carole King"},
                    new Alternative {Correct = true, Description = "Aretha Franklin"},
                    new Alternative {Correct = false, Description = "Diana Ross"}
                }
            },
            new Question
            {
                Id = 99,
                Statement = "New Caledonia is part of:",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Micronesia"},
                    new Alternative {Correct = true, Description = "Melanesia"},
                    new Alternative {Correct = false, Description = "Polynesia"},
                    new Alternative {Correct = false, Description = "Indonesia"}
                }
            },
            new Question
            {
                Id = 100,
                Statement = "Which country has a tree depicted on its flag?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Egypt"},
                    new Alternative {Correct = true, Description = "Canada"},
                    new Alternative {Correct = false, Description = "Lebanon"},
                    new Alternative {Correct = false, Description = "Morocco"}
                }
            },
            new Question
            {
                Id = 101,
                Statement = "Which French painter celebrated the Tahitian woman in his paintings?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Renoir"},
                    new Alternative {Correct = true, Description = "Gauguin"},
                    new Alternative {Correct = false, Description = "Cézanne"},
                    new Alternative {Correct = false, Description = "Monet"}
                }
            },
            new Question
            {
                Id = 102,
                Statement = "What is glucose?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Amino Acid"},
                    new Alternative {Correct = true, Description = "Carbohydrate"},
                    new Alternative {Correct = false, Description = "Lipid"},
                    new Alternative {Correct = false, Description = "Protein"}
                }
            },
            new Question
            {
                Id = 103,
                Statement = "Which of these national teams has never played in a World Cup final?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Spain"},
                    new Alternative {Correct = false, Description = "Sweden"},
                    new Alternative {Correct = false, Description = "Hungary"},
                    new Alternative {Correct = true, Description = "France"}
                }
            },
            new Question
            {
                Id = 104,
                Statement = "What is the origin of the word 'folklore'?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Dutch"},
                    new Alternative {Correct = false, Description = "English"},
                    new Alternative {Correct = false, Description = "French"},
                    new Alternative {Correct = true, Description = "Brazilian"}
                }
            },
            new Question
            {
                Id = 105,
                Statement = "Who won the first Olympic gold medal for Brazil?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Afrânio Antonio Costa"},
                    new Alternative {Correct = true, Description = "Guilherme Paraense"},
                    new Alternative {Correct = false, Description = "Fernando Soledade"},
                    new Alternative {Correct = false, Description = "Sebastião Wolf"}
                }
            },
            new Question
            {
                Id = 106,
                Statement = "What is the fourth planet in the solar system?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Jupiter"},
                    new Alternative {Correct = false, Description = "Venus"},
                    new Alternative {Correct = false, Description = "Earth"},
                    new Alternative {Correct = true, Description = "Mars"}
                }
            },
            new Question
            {
                Id = 107,
                Statement = "What is the nickname of the Ponte Preta football team?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Witch"},
                    new Alternative {Correct = false, Description = "Fox"},
                    new Alternative {Correct = false, Description = "Sorceress"},
                    new Alternative {Correct = true, Description = "Monkey"}
                }
            },
            new Question
            {
                Id = 108,
                Statement = "Who was known as the 'Eagle of The Hague'?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Jorge Amado"},
                    new Alternative {Correct = false, Description = "Eça de Queirós"},
                    new Alternative {Correct = true, Description = "Rui Barbosa"},
                    new Alternative {Correct = false, Description = "Raimundo Corrêa"}
                }
            },
            new Question
            {
                Id = 109,
                Statement = "Who wrote 'Don Quixote'?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Spinoza"},
                    new Alternative {Correct = true, Description = "Miguel de Cervantes"},
                    new Alternative {Correct = false, Description = "Carlos Conte"},
                    new Alternative {Correct = false, Description = "Angel Morita"}
                }
            },
            new Question
            {
                Id = 110,
                Statement = "Which metal has the symbol Hg?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Iron"},
                    new Alternative {Correct = false, Description = "Steel"},
                    new Alternative {Correct = true, Description = "Mercury"},
                    new Alternative {Correct = false, Description = "Gold"}
                }
            },
            new Question
            {
                Id = 111,
                Statement = "What is the name given to a set of bells?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Handrail"},
                    new Alternative {Correct = true, Description = "Carillon"},
                    new Alternative {Correct = false, Description = "Bells"},
                    new Alternative {Correct = false, Description = "Corset"}
                }
            },
            new Question
            {
                Id = 112,
                Statement = "What is the official height of the hoop in basketball?",
                Alternatives = new()
                {
                    new Alternative {Correct = true, Description = "3.05 meters"},
                    new Alternative {Correct = false, Description = "2.97 meters"},
                    new Alternative {Correct = false, Description = "3.10 meters"},
                    new Alternative {Correct = false, Description = "3.00 meters"}
                }
            },
            new Question
            {
                Id = 113,
                Statement = "Which athlete was disqualified for doping in the 1988 Olympics?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Mike Powell"},
                    new Alternative {Correct = true, Description = "Ben Johnson"},
                    new Alternative {Correct = false, Description = "Carl Lewis"},
                    new Alternative {Correct = false, Description = "Linford Christie"}
                }
            },
            new Question
            {
                Id = 114,
                Statement = "What test uses sound waves to visualize organs?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Xerography"},
                    new Alternative {Correct = true, Description = "Ultrasound"},
                    new Alternative {Correct = false, Description = "Photography"},
                    new Alternative {Correct = false, Description = "Radiography"}
                }
            },
            new Question
            {
                Id = 115,
                Statement = "What is the specialty of professionals who analyze the grooves and marks of a bullet?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Ballistics"},
                    new Alternative {Correct = true, Description = "Ballistics"},
                    new Alternative {Correct = false, Description = "Logistics"},
                    new Alternative {Correct = false, Description = "Fingerprinting"}
                }
            },
            new Question
            {
                Id = 116,
                Statement = "What was the name of the steam locomotive that traveled on the Estrada de Ferro Mauá in 1854?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Santa Fé"},
                    new Alternative {Correct = false, Description = "Loco-Breque"},
                    new Alternative {Correct = true, Description = "American"},
                    new Alternative {Correct = false, Description = "Baronesa"}
                }
            },
            new Question
            {
                Id = 117,
                Statement = "What is the palate?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Thigh"},
                    new Alternative {Correct = false, Description = "Darling"},
                    new Alternative {Correct = true, Description = "Tongue"},
                    new Alternative {Correct = false, Description = "Roof of the mouth"}
                }
            },
            new Question
            {
                Id = 118,
                Statement = "What did Stradivarius build?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Houses"},
                    new Alternative {Correct = true, Description = "Violins"},
                    new Alternative {Correct = false, Description = "Weapons"},
                    new Alternative {Correct = false, Description = "Roads"}
                }
            },
            new Question
            {
                Id = 119,
                Statement = "What is a talus?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Snow Avalanche"},
                    new Alternative {Correct = false, Description = "Fungus"},
                    new Alternative {Correct = true, Description = "Slope of Terrain"},
                    new Alternative {Correct = false, Description = "Islamic Rite"}
                }
            },
            new Question
            {
                Id = 120,
                Statement = "Which of these words is a synonym for 'complete'?",
                Alternatives = new()
                {
                    new Alternative {Correct = false, Description = "Low"},
                    new Alternative {Correct = true, Description = "Perfect"},
                    new Alternative {Correct = false, Description = "Bold"},
                    new Alternative {Correct = false, Description = "Ill"}
                }
            }
        };


        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
