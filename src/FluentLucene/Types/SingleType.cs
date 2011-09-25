using System.Globalization;
using Lucene.Net.Documents;

namespace FluentLucene.Types
{
    /// <summary>
    /// Mapping for <see cref="float"/>s.
    /// </summary>
    internal class SingleType : FieldType<float>
    {
        protected override float GetValueInternal(Field field)
        {
            return float.Parse(field.StringValue());
        }

        protected override void SetValueInternal(Field field, float value)
        {
            field.SetValue(value.ToString(CultureInfo.InvariantCulture));
        }
    }
}