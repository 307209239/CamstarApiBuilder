﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OwnerMaint_Environment
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
  public class OwnerMaint_Environment : UserCodeWithWMMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "OwnerMaint_Environment_ObjectChanges")]
    [Metadata("Changes CDO for Owner.", "OwnerChanges", false, false, false, "OwnerChanges", 1048873, true, false, false, null)]
    protected OwnerChanges_Environment _ObjectChanges;
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OwnerMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "OwnerMaint_Environment_ObjectToChange")]
    [Metadata("Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are \"Manufacturing\", \"Engineering\", \"Prototypes\", \"SalesSamples\", etc.", "Owner", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public OwnerChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (OwnerChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

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
  }
}
