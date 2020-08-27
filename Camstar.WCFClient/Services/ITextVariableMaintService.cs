// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITextVariableMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITextVariableMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_LoadESigDetails_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Parameters parameters,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TextVariableMaintMethod[] methods,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TextVariableMaint textVariableMaint,
      TextVariableMaint_Request request,
      out TextVariableMaint_Result result);
  }
}
