namespace Serene1.Migrations;

public class DefaultDBAttribute : FluentMigrator.TagsAttribute
{
    public DefaultDBAttribute()
        : base("DefaultDB")
    {
    }
}
