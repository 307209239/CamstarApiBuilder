// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionChanges_Environment
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
  public class DataPointCollectionChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionChanges_Environment_Groups")]
    [Metadata("A DataPointCollectionGroup contains a list of DataPointColletionPoint objects to be collected.  The data points may be related to each other, and presented in a vertical or horizontal format, or unrelated (Unassociated) and presented individually.", "DataPointCollectionGroupChgs", false, false, false, "DataPointCollectionGroupChgs", 1052432, false, true, false, null)]
    protected DataPointCollectionGroupChgs_Environment _Groups;
    [Metadata("A DataPointCollection contains a list of DataPointCollectionGroup objects.  A DataPointCollection can be attached to any object and allows the User entering the data to dynamically add extra samples of defined DataPoints and also dynamically define and collect new DataPoints.", "DataPointCollection", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionChanges_Environment_ListItemToChange")]
    [Metadata("A DataPointCollection contains a list of DataPointCollectionGroup objects.  A DataPointCollection can be attached to any object and allows the User entering the data to dynamically add extra samples of defined DataPoints and also dynamically define and collect new DataPoints.", "DataPointCollectionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionChanges_Environment_Instructions")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1051642, false, false, false, null)]
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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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
