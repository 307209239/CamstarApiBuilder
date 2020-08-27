// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RegulatoryAgencyMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RegulatoryAgencyMaintService : NamedDataObjectMaintBase
  {
    public RegulatoryAgencyMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRegulatoryAgencyMaintService), userProfile);
    }

    public ResultStatus Delete(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryAgencyMaintService) this._Channel).Delete(this._UserProfile, regulatoryAgencyMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(regulatoryAgencyMaint, RegulatoryAgencyMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RegulatoryAgencyMaint) null, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus Delete(RegulatoryAgencyMaint regulatoryAgencyMaint)
    {
      return this.Delete(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus Delete(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.Delete(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryAgencyMaintService) this._Channel).Freeze(this._UserProfile, regulatoryAgencyMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(regulatoryAgencyMaint, RegulatoryAgencyMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RegulatoryAgencyMaint) null, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus Freeze(RegulatoryAgencyMaint regulatoryAgencyMaint)
    {
      return this.Freeze(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus Freeze(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.Freeze(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryAgencyMaintService) this._Channel).GetWIPMsgs(this._UserProfile, regulatoryAgencyMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(regulatoryAgencyMaint, RegulatoryAgencyMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RegulatoryAgencyMaint) null, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(RegulatoryAgencyMaint regulatoryAgencyMaint)
    {
      return this.GetWIPMsgs(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.GetWIPMsgs(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryAgencyMaintService) this._Channel).Load(this._UserProfile, regulatoryAgencyMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(regulatoryAgencyMaint, RegulatoryAgencyMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RegulatoryAgencyMaint) null, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus Load(RegulatoryAgencyMaint regulatoryAgencyMaint)
    {
      return this.Load(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus Load(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.Load(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_LoadESigDetails_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryAgencyMaintService) this._Channel).LoadESigDetails(this._UserProfile, regulatoryAgencyMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(regulatoryAgencyMaint, RegulatoryAgencyMaintMethods.LoadESigDetails, (RegulatoryAgencyMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RegulatoryAgencyMaint) null, (RegulatoryAgencyMaint_LoadESigDetails_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus LoadESigDetails(RegulatoryAgencyMaint regulatoryAgencyMaint)
    {
      return this.LoadESigDetails(regulatoryAgencyMaint, (RegulatoryAgencyMaint_LoadESigDetails_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.LoadESigDetails(regulatoryAgencyMaint, (RegulatoryAgencyMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryAgencyMaintService) this._Channel).New(this._UserProfile, regulatoryAgencyMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(regulatoryAgencyMaint, RegulatoryAgencyMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RegulatoryAgencyMaint) null, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus New(RegulatoryAgencyMaint regulatoryAgencyMaint)
    {
      return this.New(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus New(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.New(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryAgencyMaintService) this._Channel).NewCopy(this._UserProfile, regulatoryAgencyMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(regulatoryAgencyMaint, RegulatoryAgencyMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RegulatoryAgencyMaint) null, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus NewCopy(RegulatoryAgencyMaint regulatoryAgencyMaint)
    {
      return this.NewCopy(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus NewCopy(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.NewCopy(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryAgencyMaintService) this._Channel).SaveAs(this._UserProfile, regulatoryAgencyMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(regulatoryAgencyMaint, RegulatoryAgencyMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RegulatoryAgencyMaint) null, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus SaveAs(RegulatoryAgencyMaint regulatoryAgencyMaint)
    {
      return this.SaveAs(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus SaveAs(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.SaveAs(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Parameters parameters,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryAgencyMaintService) this._Channel).UnFreeze(this._UserProfile, regulatoryAgencyMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(regulatoryAgencyMaint, RegulatoryAgencyMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) regulatoryAgencyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RegulatoryAgencyMaint) null, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus UnFreeze(RegulatoryAgencyMaint regulatoryAgencyMaint)
    {
      return this.UnFreeze(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RegulatoryAgencyMaint regulatoryAgencyMaint,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.UnFreeze(regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject regulatoryAgencyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RegulatoryAgencyMaint) regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) parameters, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject regulatoryAgencyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RegulatoryAgencyMaint) regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) parameters, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject regulatoryAgencyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RegulatoryAgencyMaint) regulatoryAgencyMaint, (RegulatoryAgencyMaint_LoadESigDetails_Parameters) parameters, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject regulatoryAgencyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus resultStatus = this.New((RegulatoryAgencyMaint) regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) parameters, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject regulatoryAgencyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RegulatoryAgencyMaint) regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) parameters, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject regulatoryAgencyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RegulatoryAgencyMaint) regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) parameters, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject regulatoryAgencyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RegulatoryAgencyMaint) regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) parameters, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject regulatoryAgencyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus resultStatus = this.Load((RegulatoryAgencyMaint) regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) parameters, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject regulatoryAgencyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RegulatoryAgencyMaint) regulatoryAgencyMaint, (RegulatoryAgencyMaint_Parameters) parameters, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      try
      {
        RegulatoryAgencyMaintMethod[] methods = new RegulatoryAgencyMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRegulatoryAgencyMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RegulatoryAgencyMaint cdo,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      try
      {
        return ((IRegulatoryAgencyMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RegulatoryAgencyMaint) cdo, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.GetEnvironment((RegulatoryAgencyMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RegulatoryAgencyMaint cdo,
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      result = (RegulatoryAgencyMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryAgencyMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(cdo, RegulatoryAgencyMaintMethods.ExecuteTransaction, (RegulatoryAgencyMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryAgencyMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RegulatoryAgencyMaint) cdo, (RegulatoryAgencyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RegulatoryAgencyMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RegulatoryAgencyMaint_Request) null, out RegulatoryAgencyMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RegulatoryAgencyMaint_Request request,
      out RegulatoryAgencyMaint_Result result)
    {
      return this.ExecuteTransaction((RegulatoryAgencyMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RegulatoryAgencyMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RegulatoryAgencyMaintMethod(cdo, RegulatoryAgencyMaintMethods.AddDataTransaction, (RegulatoryAgencyMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((RegulatoryAgencyMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
