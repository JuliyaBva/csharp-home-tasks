namespace HomeWork08
{
    public class Planet
    {
        string type;
        string description;
  
        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "type": return type + " exoplanet ";
                    case "description": return description;
                    default: return null;
                }
            }
            set
            {
                switch (propname)
                {
                    case "type":
                        type = value;
                        break;
                    case "description":
                        description = value;
                        break;
                }
            }
        }
    }
}