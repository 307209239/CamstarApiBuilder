// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPrefFieldDef_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UIPrefFieldDef_Environment : NamedSubentity_Environment
  {
    [Metadata("Field Expression.", "", false, false, true, "String", 1050370, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_Environment_FieldSeq")]
    [Metadata("Generic Integer", "", true, false, true, "Integer", 1048917, false, false, false, null)]
    protected Environment _FieldSeq;
    [DataMember(EmitDefaultValue = false, Name = "UIPrefFieldDef_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;

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

    public Environment FieldSeq
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldSeq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldSeq));
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
  }
}
