// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Phonebook.Crud.Model;

namespace Phonebook.Crud.Services
{
    public class PhoneBookService
    {
        private int lastId = 0;
        public PhoneBook[] PhoneBooks { get; set; } = new PhoneBook[10];

        public PhoneBookService()
        {
            PhoneBooks[0] = new PhoneBook
            {
                Id = 1,
                Name = "Aslanbek Hasanov",
                Phone = "+998914559509"
            };
            PhoneBooks[1] = new PhoneBook
            {
                Id = 2,
                Name = "Mirzabek Orziyev",
                Phone = "+998975673423"

            };
            PhoneBooks[2] = new PhoneBook 
            {
                Id = 3,
                Name = "Shahzod Islomov",
                Phone = "+998974563221"
            };
        }

        /// <summary>
        /// Checks whether phone book data is empty or not 
        /// and returns true or false in bool type.
        /// </summary>
        /// <returns></returns>
        private bool IsEmpty()
        {
            for (int iteration = 0; iteration < PhoneBooks.Length; iteration++)
            {
                PhoneBook phoneBook = PhoneBooks[iteration];
                if (phoneBook is null)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks whether the data passed to the method exists
        /// and returns true or false in bool type.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        private bool IsThere(string? name, string? phone)
        {

            for (int iteration = 0; iteration < PhoneBooks.Length; iteration++)
            {
                PhoneBook phoneBook = PhoneBooks[iteration];
                if (phoneBook is not null)
                {
                    if (phoneBook.Name.Contains(name) && phoneBook.Phone.Contains(phone))
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        /// <summary>
        /// This method serves to create new phone book information
        /// and returns true or false in bool type.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public bool Create(string name, string phone)
        {
            if(!IsThere(name, phone) && IsEmpty())
            {
                for (int iteration = 0; iteration < PhoneBooks.Length; iteration++)
                {
                    PhoneBook phoneBook = PhoneBooks[iteration];

                    if (phoneBook is null)
                    {
                        PhoneBooks[iteration] = new PhoneBook
                        {
                            Id = lastId + 1,
                            Name = name,
                            Phone = phone
                        };
                        return true;
                    }
                    else
                        lastId = phoneBook.Id;

                }

            }

            return false;
        }

        /// <summary>
        /// To get all the information
        /// </summary>
        public void ReadAllPhoneBooks()
        {
            for (int itaration = 0; itaration < PhoneBooks.Length; itaration++)
            {
                var phoneBook = PhoneBooks[itaration];
                if (phoneBook is not null && phoneBook.Id != 0)
                {
                    Console.WriteLine($"{phoneBook.Id} - {phoneBook.Name} {phoneBook.Phone}");
                }

            }

        }

        /// <summary>
        /// It serves to delete the Phone Book data by the given id
        /// and returns true or false in bool type.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeletePhoneBookById(int id)
        {
            for (int itaration = 0; itaration < PhoneBooks.Length; itaration++)
            {
                var phoneBook = PhoneBooks[itaration];

                if (phoneBook is not null)
                {
                    if (id == phoneBook.Id && phoneBook is not null)
                    {
                        PhoneBooks[itaration] = new PhoneBook
                        {
                            Id = 0,
                            Name = null,
                            Phone = null
                        };
                        return true;

                    }
                }

            }

            return false;
        }
        /// <summary>
        /// Searches for PhoneBook data by the given id and returns 
        /// action if PhoneBook type is null or data.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PhoneBook? ReadById(int? id)
        {

            for (int itaration = 0; itaration < PhoneBooks.Length; itaration++)
            {
                var phoneBook = PhoneBooks[itaration];

                if (phoneBook is not null)
                {
                    if (phoneBook.Id == id && phoneBook is not null)
                        return phoneBook;
                }
            
            }

            return null;

        }
        /// <summary>
        /// Searches Phone Book data by given id. 
        /// Updates PhoneBook data and returns true or false in bool type.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="_phoneBook"></param>
        /// <returns></returns>
        public bool Update(int id,PhoneBook _phoneBook)
        {
            for (int itaration = 0; itaration < PhoneBooks.Length; itaration++)
            {
                var phoneBook = PhoneBooks[itaration];
                if(phoneBook is not null)
                {
                    if (!IsThere(_phoneBook.Name, _phoneBook.Phone) && phoneBook.Id == id)
                    {
                        PhoneBooks[itaration] = new PhoneBook
                        {
                            Id = id,
                            Name = _phoneBook.Name,
                            Phone = _phoneBook.Phone,
                        };
                        return true;

                    }

                }
            }
            return false;
        }
    }
}
