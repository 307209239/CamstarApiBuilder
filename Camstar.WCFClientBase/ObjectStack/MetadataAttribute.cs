// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MetadataAttribute
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;

namespace Camstar.WCF.ObjectStack
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Field)]
  [Serializable]
  public class MetadataAttribute : Attribute
  {
    public string Description { get; private set; }

    public bool IsUserDefinedField { get; private set; }

    public bool IsRequired { get; private set; }

    public bool IsReadOnly { get; private set; }

    public string CDOTypeName { get; private set; }

    public FieldTypeCode FieldTypeCode { get; private set; }

    public int LabelID { get; private set; }

    public bool CreateOnInitialize { get; private set; }

    public bool IsEnum { get; private set; }

    public bool IsList { get; private set; }

    public bool HasSelVal { get; private set; }

    public string DefaultValue { get; private set; }

    public string TypeName { get; private set; }

    public MetadataAttribute()
    {
    }

    public MetadataAttribute(
      string description,
      string cDOTypeName,
      bool isUserDefinedField,
      bool isRequired,
      bool isReadOnly,
      string typeName,
      int labelID,
      bool createOnInitialize,
      bool isList,
      bool hasSelVal,
      string defaultValue)
    {
      if (cDOTypeName == null)
        throw new ArgumentNullException(nameof (cDOTypeName));
      if (typeName == null)
        throw new ArgumentNullException(nameof (typeName));
      this.Description = description;
      this.CDOTypeName = cDOTypeName;
      this.IsUserDefinedField = isUserDefinedField;
      this.IsRequired = isRequired;
      this.IsReadOnly = isReadOnly;
      this.LabelID = labelID;
      this.CreateOnInitialize = createOnInitialize;
      this.IsEnum = cDOTypeName.EndsWith("Enum");
      this.IsList = isList;
      this.HasSelVal = hasSelVal;
      this.DefaultValue = defaultValue;
      this.TypeName = typeName;
      switch (typeName)
      {
        case "BaseObjectRef":
        case "ContainerRef":
        case "NamedObjectRef":
        case "NamedSubentityRef":
        case "RevisionedObjectRef":
        case "SubentityRef":
          this.FieldTypeCode = FieldTypeCode.Reference;
          break;
        case "Boolean":
        case "Decimal":
        case "Fixed":
        case "Float":
        case "Integer":
        case "String":
        case "TimeStamp":
          this.FieldTypeCode = (FieldTypeCode) Enum.Parse(typeof (FieldTypeCode), typeName, true);
          break;
        default:
          if (typeName.EndsWith("Enum"))
          {
            this.FieldTypeCode = FieldTypeCode.Enumeration;
            break;
          }
          this.FieldTypeCode = FieldTypeCode.Object;
          break;
      }
    }
  }
}
