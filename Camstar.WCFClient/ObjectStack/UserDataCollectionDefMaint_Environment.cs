// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserDataCollectionDefMaint_Environment
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
  public class UserDataCollectionDefMaint_Environment : DataCollectionDefMaint_Environment
  {
    [Metadata("A type of data collection that is configured through the InSite modeling tool, rather than the Designer, and allows for upper and lower limits for numeric data points", "UserDataCollectionDef", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A new type of data collection that is configured through the InSite modeling tool, rather than the Designer, and allows for upper and lower limits for numeric data points", "UserDataCollectionDefBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [Metadata("A new type of data collection that is configured through the InSite modeling tool, rather than the Designer, and allows for upper and lower limits for numeric data points", "UserDataCollectionDefBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("A new type of data collection that is configured through the InSite modeling tool, rather than the Designer, and allows for upper and lower limits for numeric data points", "UserDataCollectionDefChanges", false, false, false, "UserDataCollectionDefChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefMaint_Environment_ObjectChanges")]
    protected UserDataCollectionDefChanges_Environment _ObjectChanges;

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

    public UserDataCollectionDefChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UserDataCollectionDefChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
