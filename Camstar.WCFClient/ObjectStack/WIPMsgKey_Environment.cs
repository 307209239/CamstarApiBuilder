// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgKey_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (WIPMsgLabelKey_Environment))]
  [KnownType(typeof (WIPMsgOperationKey_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class WIPMsgKey_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKey_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKey_Environment_WIPMsgDetails")]
    [Metadata("A WIPMsgDetails object contains the basic definition of a single WIP Message.  It contains the unresolved text and any processing options and message configuration.", "WIPMsgDetails", false, false, true, "WIPMsgDetails", 1049065, false, true, false, null)]
    protected WIPMsgDetails_Environment _WIPMsgDetails;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgKey_Environment_IsFrozen")]
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

    public WIPMsgDetails_Environment WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetails_Environment) this.PropertyGet(nameof (WIPMsgDetails));
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
