// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UITargetLink_Environment
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
  public class UITargetLink_Environment : Subentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UITargetLink_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLink_Environment_TargetMember")]
    [Metadata("Generic String", "", false, false, false, "String", 1052745, false, false, false, null)]
    protected Environment _TargetMember;
    [Metadata("Generic String", "", false, false, false, "String", 1052743, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UITargetLink_Environment_SourceMember")]
    protected Environment _SourceMember;
    [DataMember(EmitDefaultValue = false, Name = "UITargetLink_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

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

    public Environment TargetMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetMember), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetMember));
      }
    }

    public Environment SourceMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceMember), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SourceMember));
      }
    }

    public Environment IsFrozen
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
