// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRFailureCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRFailureCodeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_LoadESigDetails_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Parameters parameters,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRFailureCodeMaintMethod[] methods,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRFailureCodeMaint nCRFailureCodeMaint,
      NCRFailureCodeMaint_Request request,
      out NCRFailureCodeMaint_Result result);
  }
}
