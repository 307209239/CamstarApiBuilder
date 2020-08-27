// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistViewDtl_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (HistViewHistMainlineDtl_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class HistViewDtl_Environment : NamedSubentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Environment_UIFields")]
    [Metadata("Field Expression.", "", true, true, true, "String", 1052288, false, true, false, null)]
    protected Environment _UIFields;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Environment_Parent")]
    [Metadata("BaseObject", "BaseObject", true, false, true, "BaseObjectRef", 1048825, false, false, false, null)]
    protected Environment _Parent;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Environment_IsFrozen")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "HistViewDtl_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050253, false, false, false, null)]
    protected new Environment _Name;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment UIFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIFields), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIFields));
      }
    }

    public Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
