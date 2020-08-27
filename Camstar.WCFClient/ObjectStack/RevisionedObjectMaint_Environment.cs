// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObjectMaint_Environment
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
  public class RevisionedObjectMaint_Environment : Maintenance_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_Environment_ObjectChanges")]
    [Metadata("This CDO holds the changes that are being made to an Object until the user decides to make them permanent.", "RevisionedObjectChanges", false, false, false, "RevisionedObjectChanges", 1048873, true, false, false, null)]
    protected RevisionedObjectChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_Environment_ObjectToChange")]
    [Metadata("Attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.", "RevisionedObject", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("RevisionBase refers to attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.  The RevisionBase holds information common to all revisions of an object, plus information on which revision is the revision of record.", "RevisionBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_Environment_BaseToChange")]
    protected Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_Environment_ObjectListInquiry")]
    [Metadata("RevisionBase refers to attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.  The RevisionBase holds information common to all revisions of an object, plus information on which revision is the revision of record.", "RevisionBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1050976, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_Environment_SyncRevision")]
    protected Environment _SyncRevision;

    public RevisionedObjectChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RevisionedObjectChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
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

    public Environment SyncRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SyncRevision));
      }
    }
  }
}
