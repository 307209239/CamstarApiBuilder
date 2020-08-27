// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NewObject_Environment
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
  public class NewObject_Environment : ChgAttributeHistoryObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NewObject_Environment_ObjectDisplayName")]
    [Metadata("DisplayName", "", false, false, false, "String", 1049729, false, false, false, null)]
    protected new Environment _ObjectDisplayName;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NewObject_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1049730, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NewObject_Environment_ObjectRef")]
    protected new Environment _ObjectRef;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NewObject_Environment_HistoryId")]
    protected new Environment _HistoryId;

    public new Environment ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectDisplayName));
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

    public new Environment ObjectRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectRef));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
