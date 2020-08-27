// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectReferencesInfo_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ObjectToResolve_Info))]
  [Serializable]
  public class ObjectReferencesInfo_Info : ObjectAlternateKey_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_ObjectTypeValue")]
    protected Info _ObjectTypeValue;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_ObjectType")]
    protected new Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_ObjectTypeName")]
    protected new Info _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_ObjectName")]
    protected new Info _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_ObjectFields")]
    protected ObjectField_Info _ObjectFields;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_LastEditDateGMT")]
    protected Info _LastEditDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_LastEditDate")]
    protected Info _LastEditDate;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_ObjectInstance")]
    protected BaseObject_Info _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_Revision")]
    protected new Info _Revision;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_LastEditBy")]
    protected Info _LastEditBy;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Info_Description")]
    protected Info _Description;

    public Info ObjectTypeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeValue));
      }
    }

    public new Info ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectType));
      }
    }

    public new Info ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public new Info ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectName));
      }
    }

    public ObjectField_Info ObjectFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectFields), (object) value);
      }
      get
      {
        return (ObjectField_Info) this.PropertyGet(nameof (ObjectFields));
      }
    }

    public Info LastEditDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEditDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastEditDateGMT));
      }
    }

    public Info LastEditDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEditDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastEditDate));
      }
    }

    public BaseObject_Info ObjectInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstance), (object) value);
      }
      get
      {
        return (BaseObject_Info) this.PropertyGet(nameof (ObjectInstance));
      }
    }

    public new Info Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Revision));
      }
    }

    public Info LastEditBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEditBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastEditBy));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }
  }
}
