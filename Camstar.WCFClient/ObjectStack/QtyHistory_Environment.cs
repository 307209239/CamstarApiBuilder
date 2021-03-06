﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QtyHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (EmptyCarrierHistory_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class QtyHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("The user code for rollup reason.", "RollupReason", false, false, false, "NamedObjectRef", 1049500, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_RollupReason")]
    protected Environment _RollupReason;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_Qty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049209, false, false, false, null)]
    protected Environment _Qty2;
    [Metadata("History details for ChangeQty transaction.", "QtyHistoryDetails", false, false, false, "QtyHistoryDetails", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_HistoryDetails")]
    protected QtyHistoryDetails_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_ThruputSummary")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049346, false, false, false, "0")]
    protected Environment _ThruputSummary;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049210, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_UnitsLost")]
    protected Environment _UnitsLost;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_CloseWhenZero")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049342, false, false, false, "0")]
    protected Environment _CloseWhenZero;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049208, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_Qty")]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_ThruputReportingLevel")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, true, "NamedObjectRef", 1048988, false, false, false, null)]
    protected Environment _ThruputReportingLevel;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1048840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Environment_Resource")]
    protected Environment _Resource;

    public Environment RollupReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RollupReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RollupReason));
      }
    }

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

    public Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
      }
    }

    public QtyHistoryDetails_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (QtyHistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment ThruputSummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputSummary), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputSummary));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment UnitsLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitsLost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnitsLost));
      }
    }

    public Environment CloseWhenZero
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenZero), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseWhenZero));
      }
    }

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }

    public Environment ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputReportingLevel));
      }
    }

    public Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
