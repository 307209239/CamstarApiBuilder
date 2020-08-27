// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionGroup_Environment
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
  public class DataPointCollectionGroup_Environment : NamedSubentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_LastEnteredByRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1052482, false, false, false, null)]
    protected Environment _LastEnteredByRole;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_Points")]
    [Metadata("Describes a piece of data to be collected, including limits.  The user entering the data can dynamically add extra samples as well as dynamically adding new data points.", "DataPointCollectionPoint", false, false, true, "DataPointCollectionPoint", 1052429, false, true, false, null)]
    protected DataPointCollectionPoint_Environment _Points;
    [Metadata("Enumeration for the Data Point Collection Group Layout:\r\n1 = Vertical\r\n2 = Horizontal\r\n3 = Unassociated", "DPCollectionGroupLayoutEnum", false, false, true, "Integer", 1052427, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_GroupLayout")]
    protected Environment _GroupLayout;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_Sequence")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_MinimumSamples")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052428, false, false, false, null)]
    protected Environment _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_LastEnteredOn")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052483, false, false, false, null)]
    protected Environment _LastEnteredOn;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_LastEnteredOnGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052484, false, false, false, null)]
    protected Environment _LastEnteredOnGMT;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_IsFrozen")]
    protected new Environment _IsFrozen;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052426, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_Name")]
    protected new Environment _Name;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052481, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Environment_LastEnteredBy")]
    protected Environment _LastEnteredBy;

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

    public Environment LastEnteredByRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredByRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastEnteredByRole));
      }
    }

    public DataPointCollectionPoint_Environment Points
    {
      [param: In] set
      {
        this.PropertySet(nameof (Points), (object) value);
      }
      get
      {
        return (DataPointCollectionPoint_Environment) this.PropertyGet(nameof (Points));
      }
    }

    public Environment GroupLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupLayout), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GroupLayout));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment MinimumSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinimumSamples), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinimumSamples));
      }
    }

    public Environment LastEnteredOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredOn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastEnteredOn));
      }
    }

    public Environment LastEnteredOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastEnteredOnGMT));
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

    public Environment LastEnteredBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastEnteredBy));
      }
    }
  }
}
