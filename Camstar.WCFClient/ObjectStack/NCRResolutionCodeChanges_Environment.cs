﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRResolutionCodeChanges_Environment
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
  public class NCRResolutionCodeChanges_Environment : UserCodeChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeChanges_Environment_ObjectToChange")]
    [Metadata("Identifies what was done to resolve a Nonconformance.  Examples would be \"Use As Is\" or \"Scrap\".", "NCRResolutionCode", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050405, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRResolutionCodeChanges_Environment_Name")]
    protected new Environment _Name;

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