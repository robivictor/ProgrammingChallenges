//Question One
//1-Sum of Biggest Neighbor 
public static int Challenge(int[] input)
    {

        var distinct = input.Distinct().ToArray();
        var distinctSize = distinct.Length;
        var multiplicity = new int[distinctSize];

        for (int i = 0; i < distinctSize; i++)
        {
            multiplicity[i] = input.Where(r => r == distinct[i]).Count();
        }

        var max = multiplicity.Max();

        int removed = 0;

        for (int i = 0; i < distinctSize; i++)
        {
            if (multiplicity[i] < max - 1)
            {
                removed = removed + multiplicity[i];
            }
        }

        int filteredSize = input.Length - removed;

        var filtered = new int[filteredSize];

        int j = 0;
        for (int i = 0; i < distinctSize; i++)
        {
            if (multiplicity[i] >= max - 1)
            {
                for (int k = 0; k < multiplicity[i]; k++)
                {
                    filtered[j+k] = distinct[i];
                }
                j = j+multiplicity[i];
            }
        }

        int maxValue = filtered[0];

        for (int i = 0; i < filteredSize; i++)
        {
            if (filtered[i]>maxValue)
            {
                maxValue = filtered[i];
            }
        }

        return maxValue*2;
    }



//Question Two
//2-User Class 
public class User
    {
        public User()
        {
            UserNames = new List<string>();
        }

        public static List<string> UserNames { get; set; }

        public static int UserNamesCount;

        public void Add(string value)
        {
            UserNames.Add(value);
            UserNamesCount++;
        }

        public int GetUsersCount()
        {
            return UserNamesCount;
        }

    }


//Question Three
//3-John the Robot 
 public class Skill
    {
        public string SkillName { get; set; }
    }

    public class Dancing : Skill
    {
        public Dancing()
        {
            SkillName = "Dancing";
        }
    }

    public class Cooking : Skill
    {
        public Cooking()
        {
            SkillName = "Cooking";
        }
    }


    public class Humanoid
    {
        public Humanoid(Skill skill)
        {
            RobotSkill = skill.SkillName;
        }

        public Humanoid()
        {
            RobotSkill = "No Skill Defined";
        }

        public string RobotSkill { get; set; }

        public string ShowSkill()
        {
            return RobotSkill;
        }

    }



//Question Four
//4-Alexa Settings 





//Question Five
//5- Method Signature  




//Question Sigx
//6- Construction Game
    public class Building
    {
        public Building()
        {
            Rooms = new List<string>();
        }

        private List<string> Rooms { get; set; }
        private string RoomString { get; set; }

        public void Build()
        {
            var builder = new StringBuilder();
            foreach (var room in Rooms)
            {
                if (room.Equals(Rooms.Last()))
                {
                    builder.Append(room);
                }
                else
                {
                    builder.Append(room).Append(',');
                }
            }

            RoomString = builder.ToString();
        }

        public string Describe()
        {
            return RoomString;
        }

        public void AddRoom(string room)
        {
            Rooms.Add(room);
        }


    }

    public static class BuildingExtensionMethods
    {
        public static Building AddKitchen(this Building building)
        {
            building.AddRoom("Kitchen");
            return building;
        }

        public static Building AddBedroom(this Building building, string type)
        {
            if (type=="master")
            {
                building.AddRoom("master room");
            }
            else if (type=="guest")
            {
                building.AddRoom("guest room");
            }
            else
            {
                building.AddRoom("Another");
            }
            return building;
        }

        public static Building AddBalcony(this Building building)
        {
            building.AddRoom("Balcony");
            return building;
        }
    }