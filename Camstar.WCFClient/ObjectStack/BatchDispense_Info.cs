// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchDispense_Info
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
  public class BatchDispense_Info : ComponentIssue_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Info_Carrier")]
    protected new Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Info_Batch")]
    protected Info _Batch;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Info_MasterRecipe")]
    protected Info _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Info_UseMaterialFromBatch")]
    protected Info _UseMaterialFromBatch;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Info_BatchRecipeName")]
    protected Info _BatchRecipeName;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Info_BatchProductName")]
    protected Info _BatchProductName;
    [DataMember(EmitDefaultValue = false, Name = "BatchDispense_Info_Operation")]
    protected new Info _Operation;

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public new Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public Info Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Batch));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MasterRecipe));
      }
    }

    public Info UseMaterialFromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMaterialFromBatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseMaterialFromBatch));
      }
    }

    public Info BatchRecipeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchRecipeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BatchRecipeName));
      }
    }

    public Info BatchProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BatchProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BatchProductName));
      }
    }

    public new Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }
  }
}
