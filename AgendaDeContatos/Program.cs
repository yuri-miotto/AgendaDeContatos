using AgendaDeContatos;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Contact contact = new Contact("Yuri", "9999-7777");
        //contact.Address.EditStreet("Av Brasil, 100");
        //contact.Address.EditPostalCode("14810-000");
        //contact.Address.EditState("SP");
        //contact.Address.EditCity("Araraquara");
        //contact.Address.EditCountry("Brasil");

        //Contact contact2 = new Contact("Pestana", "3333-7777");
        //contact2.Address.EditStreet("Av Portugal, 444");
        //contact2.Address.EditPostalCode("14810-200");
        //contact2.Address.EditState("RJ");
        //contact2.Address.EditCity("Rio de Janeiro");
        //contact2.Address.EditCountry("Brasil");

        //contact.Email = "yuri@gmail.com";

        //Console.WriteLine(contact);

        List<Contact> phonebook = new List<Contact>();

        //phonebook.Add(contact);
        //phonebook.Add(contact2);

        void PrintPhonebook(List<Contact> l)
        {
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }

        //PrintPhonebook(phonebook);

        //phonebook.Remove(contact);

        //PrintPhonebook(phonebook);

        phonebook.OrderBy(x => x.Name);

        int op;

        do
        {
            op = Menu();

            switch (op)
            {
                case 1:
                    phonebook.Add(CreateContact());
                    break;

                case 2:
                    EditContact();
                    break;

                case 3:
                    phonebook.Remove(DeleteContact());
                    break;

                case 4:
                    PrintPhonebook(phonebook); 
                    break;

                case 5:
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        while (true);

        

        

        int Menu()
        {
            Console.WriteLine("\n\nMENU OPÇÕES:\n1-Inserir contato\n2-Editar contato\n3-Remover contato\n4-Mostrar agenda\n5-Sair\n\nEscolha uma opção: ");
            var xpto = int.Parse(Console.ReadLine());
            return xpto;
        }


        Contact CreateContact()
        {
            Console.WriteLine("Informe o nome: ");
            string n = Console.ReadLine();
            Console.WriteLine("Informe o telefone: ");
            var t = Console.ReadLine();

            foreach (var item in phonebook)
            {
                if (item.Phone.Equals(t))
                {
                    Console.WriteLine("Este número de telefone já existe!!!");
                    return null;
                }
            }
            Contact contact = new(n, t);
            return contact;

        }


        Contact DeleteContact()
        {
            Console.WriteLine("Informe o nome: ");
            var n = Console.ReadLine();
            foreach (var item in phonebook)
            {
                if (item.Name.Equals(n))
                {
                    return item;
                }
            }
            return null;
        }

        void EditContact()
        {
            Console.WriteLine("Informe o nome do contato que gostaria de editar: ");
            var n = Console.ReadLine();
            foreach (Contact item in phonebook)
            {
                if (item.Name.Equals(n))
                {
                        int op2;
                        op2 = Menu2();

                        switch (op2)
                        {
                            case 1:
                                Console.WriteLine("Edite o nome: ");
                                item.Name = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("Edite o telefone: ");
                                item.Phone = Console.ReadLine();
                                break;

                            case 3:
                                Console.WriteLine("Edite o email: ");
                                item.Email = Console.ReadLine();
                                break;

                            case 4:
                                Console.WriteLine("Edite o endereço: ");
                                item.Address.Street = Console.ReadLine();
                                break;

                            case 5:
                                Console.WriteLine("Edite a cidade: ");
                                item.Address.City = Console.ReadLine();
                                break;

                            case 6:
                                Console.WriteLine("Edite o estado: ");
                                item.Address.State = Console.ReadLine();
                                break;

                            case 7:
                                Console.WriteLine("Edite o CEP: ");
                                item.Address.PostalCode = Console.ReadLine();
                                break;

                            case 8:
                                Console.WriteLine("Edite o país: ");
                                item.Address.Country = Console.ReadLine();
                                break;

                            default:
                                Console.WriteLine("Opção inválida");
                                break;
                        }
                }
            }
        }

        int Menu2()
        {
            Console.WriteLine("\nMENU OPÇÕES PARA EDIÇÂO:\n1-Editar nome\n2-Editar telefone\n3-Editar email\n4-Editar endereço\n5-Editar cidade" +
                "\n6-Editar estado\n7-Editar CEP\n8-Editar pais\n\nEscolha uma opção: ");
            var xpto = int.Parse(Console.ReadLine());
            return xpto;
        }

    }

    
}