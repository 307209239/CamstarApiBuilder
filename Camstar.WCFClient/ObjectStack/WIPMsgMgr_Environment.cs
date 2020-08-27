// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgMgr_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (WIPMsgMgrInquiry_Environment))]
  [Serializable]
  public class WIPMsgMgr_Environment : Subentity_Environment
  {
    [Metadata("This CDO contains the filtering criteria for WIP Message retrieval.", "WIPMsgCriteria", false, false, false, "WIPMsgCriteria", 1049081, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Environment_WIPMsgCriteria")]
    protected WIPMsgCriteria_Environment _WIPMsgCriteria;
    [Metadata("This object contains the resolved message and values used to acknowledge the message during processing.  It is a temporary object created during the GetWIPMsgs function.", "WIPMsg", false, false, true, "WIPMsg", 1049080, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Environment_WIPMsgs")]
    protected WIPMsg_Environment _WIPMsgs;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1048623, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Environment_Containers")]
    protected Environment _Containers;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Environment_WIPMsgRetrievalDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049842, false, false, false, null)]
    protected Environment _WIPMsgRetrievalDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Environment_FilterOnServiceType")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049840, false, false, false, "1")]
    protected Environment _FilterOnServiceType;

    public WIPMsgCriteria_Environment WIPMsgCriteria
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgCriteria), (object) value);
      }
      get
      {
        return (WIPMsgCriteria_Environment) this.PropertyGet(nameof (WIPMsgCriteria));
      }
    }

    public WIPMsg_Environment WIPMsgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgs), (object) value);
      }
      get
      {
        return (WIPMsg_Environment) this.PropertyGet(nameof (WIPMsgs));
      }
    }

    public Environment Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Containers));
      }
    }

    public Environment WIPMsgRetrievalDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgRetrievalDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMsgRetrievalDateGMT));
      }
    }

    public Environment FilterOnServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterOnServiceType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterOnServiceType));
      }
    }
  }
}
