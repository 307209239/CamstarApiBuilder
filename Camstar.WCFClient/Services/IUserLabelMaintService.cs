// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUserLabelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUserLabelMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_LoadESigDetails_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Parameters parameters,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UserLabelMaintMethod[] methods,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UserLabelMaint userLabelMaint,
      UserLabelMaint_Request request,
      out UserLabelMaint_Result result);
  }
}
