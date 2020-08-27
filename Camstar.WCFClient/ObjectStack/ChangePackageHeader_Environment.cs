// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageHeader_Environment
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
  public class ChangePackageHeader_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_StepIcon")]
    [Metadata("URL", "", false, false, false, "String", 16777285, false, false, false, null)]
    protected Environment _StepIcon;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_Step")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1049032, false, false, false, null)]
    protected Environment _Step;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_ChangePackageImportStatus")]
    [Metadata("ChangePackageImportStatus", "ChangePackageImportStatusEnum", false, false, false, "Integer", 16777369, false, false, false, null)]
    protected Environment _ChangePackageImportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_Workflow")]
    [Metadata("A Workflow defines the route and processing required for a process, \r\n\r\nA Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs", "ChangeMgtWorkflow", false, false, true, "RevisionedObjectRef", 1048654, false, false, false, null)]
    protected Environment _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_ChangePackage")]
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 1053240, false, false, true, null)]
    protected Environment _ChangePackage;
    [Metadata("PackageStatus", "PackageStatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_Status")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_LastUpdatedDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1053256, false, false, false, null)]
    protected Environment _LastUpdatedDate;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_Description")]
    protected Environment _Description;
    [Metadata("String to be evaluated to produce a value at run-time.", "", false, false, true, "String", 1053257, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_TargetSystemName")]
    protected Environment _TargetSystemName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048824, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_OwnerName")]
    protected Environment _OwnerName;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, true, "DocumentSet", 1048646, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_DocumentSets")]
    protected DocumentSet_Environment _DocumentSets;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1053234, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_Name")]
    protected Environment _Name;
    [Metadata("A Document Entry is used to include a Document in a Document and provide a description for it within the Document Set. If there is more than one Document within a Document Set when a request is made to display a Document Set, the list of Document Entries is used to build a selection list. (Note that a one-to-one relationship between a Document Set and a Document is likely the common scenario).", "DocumentEntry", false, false, false, "NamedSubentityRef", 16777592, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageHeader_Environment_Documents")]
    protected Environment _Documents;

    public Environment StepIcon
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepIcon), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StepIcon));
      }
    }

    public Environment Step
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

    public Environment ChangePackageImportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageImportStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackageImportStatus));
      }
    }

    public Environment Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workflow));
      }
    }

    public Environment ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public Environment LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment TargetSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystemName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetSystemName));
      }
    }

    public Environment OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerName));
      }
    }

    public DocumentSet_Environment DocumentSets
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSets), (object) value);
      }
      get
      {
        return (DocumentSet_Environment) this.PropertyGet(nameof (DocumentSets));
      }
    }

    public Environment Name
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

    public Environment Documents
    {
      [param: In] set
      {
        this.PropertySet(nameof (Documents), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Documents));
      }
    }
  }
}
