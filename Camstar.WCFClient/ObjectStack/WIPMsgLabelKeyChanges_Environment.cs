// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgLabelKeyChanges_Environment
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
  public class WIPMsgLabelKeyChanges_Environment : WIPMsgKeyChanges_Environment
  {
    [Metadata("Identifier for relating a WIP Message to one or more Steps. WIP Messages defined for all Modeling Entities except a Step or Operation can be qualified with a WIP Message Label. This allows the same message to be associated with multiple Steps.", "", false, false, false, "String", 1049066, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKeyChanges_Environment_Label")]
    protected Environment _Label;
    [Metadata("Changes CDO for WIPMsgDetail.", "WIPMsgDetailChanges", false, false, false, "WIPMsgDetailChanges", 1049065, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKeyChanges_Environment_WIPMsgDetails")]
    protected new WIPMsgDetailChanges_Environment _WIPMsgDetails;
    [Metadata("A WIPMsgLabelKey is used to refer to a WIPMsgDetails Object.  A list of these is specified in the WIPMsgDefMgr object attached to an instance of a modeling entity.  Messages referred to by this type of key are filtered based on the label in the current step.", "WIPMsgLabelKey", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgLabelKeyChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public Environment Label
    {
      [param: In] set
      {
        this.PropertySet(nameof (Label), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Label));
      }
    }

    public new WIPMsgDetailChanges_Environment WIPMsgDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDetails), (object) value);
      }
      get
      {
        return (WIPMsgDetailChanges_Environment) this.PropertyGet(nameof (WIPMsgDetails));
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
  }
}
