namespace AbstractModels
{
    public abstract class DtoAbstract  
    {
        private Guid? dto_guid_id;
        private int? dto_int_id;

        private DateTime dto_date;

        public DtoAbstract(object id, object date )
        {
            if (!DtoInit(id,date))
            {
                throw new InitException();
            }
        }

        private bool DtoInit(object id, object date)
        {
            if (id == null || date == null)
            {
                return false;
                throw new ArgumentNullException();
            }

            if (Guid.TryParse((string?)id, out var _guid_id))
            {
                dto_guid_id = _guid_id;
            }
            else if (int.TryParse((string)id, out int _int_id))
            {
                dto_int_id = _int_id;
            }
            else
            {
                return false;
                throw new ArgumentNullException();
            }

            
            if (DateTime.TryParse((string)date, out DateTime _date))
            {
                dto_date = _date;
            }
            else
            {
                return false;
                throw new ArgumentNullException();
            }

            return true;
        }
    }
}