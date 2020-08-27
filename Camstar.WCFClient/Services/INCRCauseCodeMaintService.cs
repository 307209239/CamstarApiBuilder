// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.INCRCauseCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface INCRCauseCodeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_LoadESigDetails_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Parameters parameters,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      NCRCauseCodeMaintMethod[] methods,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      NCRCauseCodeMaint nCRCauseCodeMaint,
      NCRCauseCodeMaint_Request request,
      out NCRCauseCodeMaint_Result result);
  }
}
