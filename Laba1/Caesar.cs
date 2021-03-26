using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public class Caesar
    {
        public static string CaesarMethod(string str, uint sdv, string dir, string alph, string action)
        {
            int num = Convert.ToInt32(sdv);
            char[] buffer = str.ToCharArray();
            int max = 0;

            List<char> lower = new List<char>()
            {
                'а' , 'б' , 'в' , 'г' , 'д' , 'е' , 'ё' , 'ж' , 'з' , 'и' , 'й' ,
                'к' , 'л' , 'м' , 'н' , 'о' , 'п' , 'р' , 'с' , 'т' , 'у' , 'ф' ,
                'х' , 'ц' , 'ч' , 'ш' , 'щ' , 'ъ' , 'ы' , 'ь' , 'э' , 'ю' , 'я'
            };

            List<char> upper = new List<char>()
            {
                'А' , 'Б' , 'В' , 'Г' , 'Д' , 'Е' , 'Ё' , 'Ж' , 'З' , 'И' , 'Й' ,
                'К' , 'Л' , 'М' , 'Н' , 'О' , 'П' , 'Р' , 'С' , 'Т' , 'У' , 'Ф' ,
                'Х' , 'Ц' , 'Ч' , 'Ш' , 'Щ' , 'Ъ' , 'Ы' , 'Ь' , 'Э' , 'Ю' , 'Я'
            };

            List<char> nums = new List<char>()
            {
                '1' , '2' , '3' , '4' , '5' , '6' , '7' , '8' , '9' , '0'
            };

            if (alph == "one")
            {
                max = 42;
                lower.AddRange(nums);
                upper.AddRange(nums);
            }
            else
            {
                max = 32;
            }

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (upper.Contains(letter) || lower.Contains(letter) || nums.Contains(letter))
                {
                    if ((dir == "Right" && action == "encode") || (dir == "Left" && action == "decode"))
                    {
                        if (Char.IsUpper(letter) || Char.IsDigit(letter))
                        {
                            if (alph == "one")
                            {
                                if ((upper.IndexOf(letter) + num) > max)
                                {
                                    letter = upper[(num + upper.IndexOf(letter)) % (max + 1)];
                                }
                                else
                                {
                                    letter = upper[upper.IndexOf(letter) + num];
                                }
                            }
                            else
                            {
                                if (Char.IsUpper(letter))
                                {
                                    if ((upper.IndexOf(letter) + num) > max)
                                    {
                                        letter = upper[(num + upper.IndexOf(letter)) % (max + 1)];
                                    }
                                    else
                                    {
                                        letter = upper[upper.IndexOf(letter) + num];
                                    }
                                }
                                else
                                {
                                    if ((nums.IndexOf(letter) + num) > 9)
                                    {
                                        letter = nums[(num + nums.IndexOf(letter)) % (10)];
                                    }
                                    else
                                    {
                                        letter = nums[nums.IndexOf(letter) + num];
                                    }
                                }
                            }
                        }
                        else if (Char.IsLower(letter) || Char.IsDigit(letter))
                        {
                            if (alph == "one")
                            {
                                if ((lower.IndexOf(letter) + num) > max)
                                {
                                    letter = lower[(num + lower.IndexOf(letter)) % (max + 1)];
                                }
                                else
                                {
                                    letter = lower[lower.IndexOf(letter) + num];
                                }
                            }
                            else
                            {
                                if (Char.IsLower(letter))
                                {
                                    if ((lower.IndexOf(letter) + num) > max)
                                    {
                                        letter = lower[(num + lower.IndexOf(letter)) % (max + 1)];
                                    }
                                    else
                                    {
                                        letter = lower[lower.IndexOf(letter) + num];
                                    }
                                }
                                else
                                {
                                    if ((nums.IndexOf(letter) + num) > 9)
                                    {
                                        letter = nums[(num + nums.IndexOf(letter)) % (10)];
                                    }
                                    else
                                    {
                                        letter = nums[nums.IndexOf(letter) + num];
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Char.IsUpper(letter) || Char.IsDigit(letter))
                        {
                            if (alph == "one")
                            {
                                if ((upper.IndexOf(letter) - num) < 0)
                                {
                                    letter = upper[(max + 1) + (upper.IndexOf(letter) - num)];
                                }
                                else
                                {
                                    letter = upper[upper.IndexOf(letter) - num];
                                }
                            }
                            else
                            {
                                if (Char.IsUpper(letter))
                                {
                                    if ((upper.IndexOf(letter) - num) < 0)
                                    {
                                        letter = upper[(max + 1) + (upper.IndexOf(letter) - num)];
                                    }
                                    else
                                    {
                                        letter = upper[upper.IndexOf(letter) - num];
                                    }
                                }
                                else
                                {
                                    if ((nums.IndexOf(letter) - num) < 0)
                                    {
                                        letter = nums[((40) + (nums.IndexOf(letter) - num))%10];
                                    }
                                    else
                                    {
                                        letter = nums[nums.IndexOf(letter) - num];
                                    }
                                }
                            }
                        }
                        else if (Char.IsLower(letter) || Char.IsDigit(letter))
                        {
                            if (alph == "one")
                            {
                                if ((lower.IndexOf(letter) - num) < 0)
                                {
                                    letter = lower[(max + 1) + (lower.IndexOf(letter) - num)];
                                }
                                else
                                {
                                    letter = lower[lower.IndexOf(letter) - num];
                                }
                            }
                            else
                            {
                                if (Char.IsLower(letter))
                                {
                                    if ((lower.IndexOf(letter) - num) < 0)
                                    {
                                        letter = lower[(max + 1) + (lower.IndexOf(letter) - num)];
                                    }
                                    else
                                    {
                                        letter = lower[lower.IndexOf(letter) - num];
                                    }
                                }
                                else
                                {
                                    if ((nums.IndexOf(letter) - num) < 0)
                                    {
                                        letter = nums[((40) + (nums.IndexOf(letter) - num))%10];
                                    }
                                    else
                                    {
                                        letter = nums[nums.IndexOf(letter) - num];
                                    }
                                }
                            }
                        }
                    }
                    buffer[i] = letter;
                }
            }
            return new string(buffer);
        }
    }
}
