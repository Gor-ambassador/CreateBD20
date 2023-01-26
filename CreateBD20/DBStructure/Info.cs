namespace CreateDB20.DBStructure
{
    public class Info
    {
        public int InfoId { get; set; }
        public string Name { get; set; }
        public string Port { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }


        public static bool operator<(Info left, Info right)
        {
            if (left.RoomNumber == right.RoomNumber)
            {
                if (left.Port == right.Port)
                {
                    if (left.Name == right.Name)
                        return false;
                    else if (string.Compare(left.Name, right.Name) < 0)
                        return true;
                    return false;
                }
                else if (string.Compare(left.Port, right.Port) < 0)
                    return true;
                return false;
            }
            else if (left.RoomNumber < right.RoomNumber)
                return true;

            return false;
        }

        public static bool operator>(Info left, Info right)
        {
            if (left.RoomNumber == right.RoomNumber)
            {
                if (left.Port == right.Port)
                {
                    if (left.Name == right.Name)
                        return false;
                    else if (string.Compare(left.Name, right.Name) > 0)
                        return true;
                    return false;
                }
                else if (string.Compare(left.Port, right.Port) > 0)
                    return true;
                return false;
            }
            else if (left.RoomNumber > right.RoomNumber)
                return true;

            return false;
        }

        public static bool operator <=(Info left, Info right)
        {
            if (left.RoomNumber == right.RoomNumber)
            {
                if (left.Port == right.Port)
                {
                    if (left.Name == right.Name)
                        return true;
                    else if (string.Compare(left.Name, right.Name) < 0)
                        return true;
                    return false;
                }
                else if (string.Compare(left.Port, right.Port) < 0)
                    return true;
                return false;
            }
            else if (left.RoomNumber < right.RoomNumber)
                return true;

            return false;
        }

        public static bool operator >=(Info left, Info right)
        {
            if (left.RoomNumber == right.RoomNumber)
            {
                if (left.Port == right.Port)
                {
                    if (left.Name == right.Name)
                        return true;
                    else if (string.Compare(left.Name, right.Name) > 0)
                        return true;
                    return false;
                }
                else if (string.Compare(left.Port, right.Port) > 0)
                    return true;
                return false;
            }
            else if (left.RoomNumber > right.RoomNumber)
                return true;

            return false;
        }
    }
}
