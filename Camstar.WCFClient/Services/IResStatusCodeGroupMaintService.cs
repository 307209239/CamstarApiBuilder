// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IResStatusCodeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IResStatusCodeGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_LoadESigDetails_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Parameters parameters,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ResStatusCodeGroupMaintMethod[] methods,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ResStatusCodeGroupMaint resStatusCodeGroupMaint,
      ResStatusCodeGroupMaint_Request request,
      out ResStatusCodeGroupMaint_Result result);
  }
}
