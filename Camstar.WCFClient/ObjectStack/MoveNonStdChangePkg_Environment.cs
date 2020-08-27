// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveNonStdChangePkg_Environment
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
  public class MoveNonStdChangePkg_Environment : BPMoveNonStd_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStdChangePkg_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 16777624, false, false, false, null)]
    protected new Environment _Comments;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, true, false, "NamedObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStdChangePkg_Environment_TrackableObject")]
    protected new Environment _TrackableObject;
    [Metadata("Detail information about a change package.", "ChangePackageHeader", false, false, false, "ChangePackageHeader", 1053248, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStdChangePkg_Environment_ChangePackageHeader")]
    protected ChangePackageHeader_Environment _ChangePackageHeader;
    [Metadata("This specification (Spec) describes the processing that takes place at a Step within a Workflow for change management.", "ChangeMgtSpec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStdChangePkg_Environment_Spec")]
    protected new Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStdChangePkg_Environment_Step")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.", "ChangeMgtSpecStep", false, false, false, "NamedSubentityRef", 1049032, false, false, true, null)]
    protected new Environment _Step;

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public new Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public ChangePackageHeader_Environment ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader_Environment) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }

    public new Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
      }
    }

    public new Environment Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Step));
      }
    }
  }
}
