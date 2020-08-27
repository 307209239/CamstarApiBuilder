// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IProductionEventInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IProductionEventInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ProductionEventInquiry productionEventInquiry,
      ProductionEventInquiry_Parameters parameters,
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ProductionEventInquiryMethod[] methods,
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ProductionEventInquiry productionEventInquiry,
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ProductionEventInquiry productionEventInquiry,
      ProductionEventInquiry_Request request,
      out ProductionEventInquiry_Result result);
  }
}
