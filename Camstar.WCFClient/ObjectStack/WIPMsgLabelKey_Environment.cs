﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgLabelKey_Environment
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
  public class WIPMsgLabelKey_Environment : WIPMsgKey_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKey_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Identifier for relating a WIP Message to one or more Steps. WIP Messages defined for all Modeling Entities except a Step or Operation can be qualified with a WIP Message Label. This allows the same message to be associated with multiple Steps.", "", false, false, true, "String", 1049066, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKey_Environment_Label")]
    protected Environment _Label;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKey_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;

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

    public Environment Label
    {
      [param: In] set
      {
        this.PropertySet(nameof (Label), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Label));
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
