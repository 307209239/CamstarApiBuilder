﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PELabelMapChanges_Environment
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
  public class PELabelMapChanges_Environment : LabelTxnMapChanges_Environment
  {
    [Metadata("Contains a match between a service and a label definition to be printed.", "PELabelMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PELabelMapChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PELabelMapChanges_Environment_TxnType")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1048909, false, false, true, null)]
    protected new Environment _TxnType;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnType));
      }
    }
  }
}
