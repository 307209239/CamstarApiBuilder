﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureSeverityMaint_Environment
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
  public class FailureSeverityMaint_Environment : UserCodeMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "FailureSeverityMaint_Environment_ObjectToChange")]
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverity", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FailureSeverityMaint_Environment_ObjectChanges")]
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverityChanges", false, false, false, "FailureSeverityChanges", 1048873, true, false, false, null)]
    protected FailureSeverityChanges_Environment _ObjectChanges;
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverity", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureSeverityMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

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

    public FailureSeverityChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (FailureSeverityChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
