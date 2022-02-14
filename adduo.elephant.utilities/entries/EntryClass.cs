using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;

namespace adduo.elephant.utilities.entries
{
    public abstract class EntryClass
    {
        [JsonIgnore()]
        public List<Entry> Entries { get; private set; }

        [JsonIgnore()]
        public HttpStatusCode HttpStatusCode { get; protected set; }

        public EntryClass()
        {
            ResetEntry();

            InitEntries();
        }

        public void AddEntry(Entry entryDto)
        {
            Entries.Add(entryDto);
        }

        public void ResetEntry()
        {
            Entries = new List<Entry>();
        }

        /// <summary>
        /// Para indicar quais propriedades sofrerão validação.
        /// </summary>
        public abstract void AddEntries();

        /// <summary>
        /// Para adicionar validadores customizados às propriedades;
        /// Utilizar o método AddValidation de cada propriedade;
        /// </summary>
        public virtual void AddValidators() { }

        /// <summary>
        /// Para iniciar cada propriedade;
        /// Ex: Nome = new EntryName();
        /// </summary>
        public abstract void InitEntries();

        public virtual void Validate()
        {
            AddEntries();
            AddValidators();

            Reset();

            foreach (var entry in this.Entries)
            {
                entry.Validate();
            }

            SetOkHttpStatusCode();

            if(AnyFieldIsInvalid())
            {
                SetBadRequestHttpStatusCode();
            }
        }

        public void Reset()
        {
            foreach (var entry in this.Entries)
            {
                entry.Reset();
            }
        }

        public virtual bool AllFieldsAreValid()
        {
            return Entries.All(a => a.Status == StatusCode.VALID);
        }

        public bool AnyFieldIsValid()
        {
            return Entries.Any(a => a.Status == StatusCode.VALID);
        }

        public bool AnyFieldIsInvalid()
        {
            return Entries.Any(a => a.Status == StatusCode.INVALID);
        }

        #region HttpStatusCode
        public void SetHttpStatusCode(HttpStatusCode httpStatusCode)
        {
            HttpStatusCode = httpStatusCode;
        }

        public void SetConflictHttpStatusCode()
        {
            SetHttpStatusCode(HttpStatusCode.Conflict);
        }

        public void SetOkHttpStatusCode()
        {
            SetHttpStatusCode(HttpStatusCode.OK);
        }

        public void SetNotFoundHttpStatusCode()
        {
            SetHttpStatusCode(HttpStatusCode.NotFound);
        }

        public void SetBadRequestHttpStatusCode()
        {
            SetHttpStatusCode(HttpStatusCode.BadRequest);
        }

        public void SetAcceptedHttpStatusCode()
        {
            SetHttpStatusCode(HttpStatusCode.Accepted);
        }

        public void SetUnauthorizedHttpStatusCode()
        {
            SetHttpStatusCode(HttpStatusCode.Unauthorized);
        }

        public void SetAmbiguousHttpStatusCode()
        {
            SetHttpStatusCode(HttpStatusCode.Ambiguous);
        }

        public void SetInternalServerErrorHttpStatusCode()
        {
            SetHttpStatusCode(HttpStatusCode.InternalServerError);
        }

        #endregion

    }

}
