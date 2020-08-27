// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SetupMaint_Environment
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
  public class SetupMaint_Environment : RevisionedObjectMaint_Environment
  {
    [Metadata("Changes CDO for Setup.", "SetupChanges", false, false, false, "SetupChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetupMaint_Environment_ObjectChanges")]
    protected SetupChanges_Environment _ObjectChanges;
    [Metadata("A Setup Definition describes the work required, materials required, and estimates how long it will take to setup for a specific task. A typical use of a Setup Definition is to describe what it will take to prepare a machine for processing a batch or multiple batches of material. A Setup can reference an external document and/or an InstructionSet to describe the setup work required.\r\n\r\nEach Setup can also include a reference to a Recipe file for downloading to a machine. Recipe files are stored as Documents. The associated Document Viewer is the program to launch for downloading (the recipe) to a machine.", "SetupBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetupMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetupMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SetupMaint_Environment_ObjectListInquiry")]
    [Metadata("A Setup Definition describes the work required, materials required, and estimates how long it will take to setup for a specific task. A typical use of a Setup Definition is to describe what it will take to prepare a machine for processing a batch or multiple batches of material. A Setup can reference an external document and/or an InstructionSet to describe the setup work required.\r\n\r\nEach Setup can also include a reference to a Recipe file for downloading to a machine. Recipe files are stored as Documents. The associated Document Viewer is the program to launch for downloading (the recipe) to a machine.", "SetupBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;

    public SetupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SetupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment BaseToChange
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
