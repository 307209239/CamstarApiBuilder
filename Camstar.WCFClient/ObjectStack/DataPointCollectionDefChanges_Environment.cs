// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionDefChanges_Environment
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
  public class DataPointCollectionDefChanges_Environment : DataCollectionDefChanges_Environment
  {
    [Metadata("A DataPointCollectionGroup contains a list of DataPointColletionPoint objects to be collected.  The data points may be related to each other, and presented in a vertical or horizontal format, or unrelated (Unassociated) and presented individually.", "DataPointCollectionGroupChgs", false, false, false, "DataPointCollectionGroupChgs", 1052462, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Environment_Groups")]
    protected DataPointCollectionGroupChgs_Environment _Groups;
    [Metadata("A data collection that can be processed from any Shopfloor service.", "DataPointCollectionDefBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Environment_Base")]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Environment_ObjectToChange")]
    [Metadata("A data collection that can be processed from any Shopfloor service.", "DataPointCollectionDef", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Environment_ParametricDataDefType")]
    [Metadata("CDO Definition Id", "", false, false, true, "Integer", 1050394, false, false, true, null)]
    protected new Environment _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052940, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1051642, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Environment_Instructions")]
    protected Environment _Instructions;

    public DataPointCollectionGroupChgs_Environment Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (DataPointCollectionGroupChgs_Environment) this.PropertyGet(nameof (Groups));
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

    public new Environment ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParametricDataDefType));
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

    public Environment Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Instructions));
      }
    }
  }
}
