// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SetupChanges_Environment
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
  public class SetupChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Environment_ResourceGroup")]
    protected Environment _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Environment_StdSetupLaborTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049657, false, false, false, null)]
    protected Environment _StdSetupLaborTime;
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049658, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Environment_StdSetupTime")]
    protected Environment _StdSetupTime;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050231, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1048646, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Environment_DocumentSet")]
    protected Environment _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Environment_ObjectToChange")]
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SetupChanges_Environment_Base")]
    [Metadata("A Setup Definition describes the work required, materials required, and estimates how long it will take to setup for a specific task. A typical use of a Setup Definition is to describe what it will take to prepare a machine for processing a batch or multiple batches of material. A Setup can reference an external document and/or an InstructionSet to describe the setup work required.\r\n\r\nEach Setup can also include a reference to a Recipe file for downloading to a machine. Recipe files are stored as Documents. The associated Document Viewer is the program to launch for downloading (the recipe) to a machine.", "SetupBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;

    public Environment ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Environment StdSetupLaborTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdSetupLaborTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdSetupLaborTime));
      }
    }

    public Environment StdSetupTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdSetupTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdSetupTime));
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

    public Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentSet));
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

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }
  }
}
