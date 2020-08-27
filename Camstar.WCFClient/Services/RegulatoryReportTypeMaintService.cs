// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RegulatoryReportTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RegulatoryReportTypeMaintService : UserCodeMaintBase
  {
    public RegulatoryReportTypeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRegulatoryReportTypeMaintService), userProfile);
    }

    public ResultStatus Delete(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryReportTypeMaintService) this._Channel).Delete(this._UserProfile, regulatoryReportTypeMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(regulatoryReportTypeMaint, RegulatoryReportTypeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RegulatoryReportTypeMaint) null, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus Delete(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint)
    {
      return this.Delete(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus Delete(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.Delete(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryReportTypeMaintService) this._Channel).Freeze(this._UserProfile, regulatoryReportTypeMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(regulatoryReportTypeMaint, RegulatoryReportTypeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RegulatoryReportTypeMaint) null, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint)
    {
      return this.Freeze(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.Freeze(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryReportTypeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, regulatoryReportTypeMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(regulatoryReportTypeMaint, RegulatoryReportTypeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RegulatoryReportTypeMaint) null, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint)
    {
      return this.GetWIPMsgs(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.GetWIPMsgs(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryReportTypeMaintService) this._Channel).Load(this._UserProfile, regulatoryReportTypeMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(regulatoryReportTypeMaint, RegulatoryReportTypeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RegulatoryReportTypeMaint) null, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus Load(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint)
    {
      return this.Load(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus Load(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.Load(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_LoadESigDetails_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryReportTypeMaintService) this._Channel).LoadESigDetails(this._UserProfile, regulatoryReportTypeMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(regulatoryReportTypeMaint, RegulatoryReportTypeMaintMethods.LoadESigDetails, (RegulatoryReportTypeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RegulatoryReportTypeMaint) null, (RegulatoryReportTypeMaint_LoadESigDetails_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint)
    {
      return this.LoadESigDetails(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_LoadESigDetails_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.LoadESigDetails(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryReportTypeMaintService) this._Channel).New(this._UserProfile, regulatoryReportTypeMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(regulatoryReportTypeMaint, RegulatoryReportTypeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RegulatoryReportTypeMaint) null, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus New(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint)
    {
      return this.New(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus New(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.New(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryReportTypeMaintService) this._Channel).NewCopy(this._UserProfile, regulatoryReportTypeMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(regulatoryReportTypeMaint, RegulatoryReportTypeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RegulatoryReportTypeMaint) null, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint)
    {
      return this.NewCopy(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.NewCopy(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryReportTypeMaintService) this._Channel).SaveAs(this._UserProfile, regulatoryReportTypeMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(regulatoryReportTypeMaint, RegulatoryReportTypeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RegulatoryReportTypeMaint) null, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint)
    {
      return this.SaveAs(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.SaveAs(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Parameters parameters,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryReportTypeMaintService) this._Channel).UnFreeze(this._UserProfile, regulatoryReportTypeMaint, parameters, request, out result) : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(regulatoryReportTypeMaint, RegulatoryReportTypeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) regulatoryReportTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RegulatoryReportTypeMaint) null, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint)
    {
      return this.UnFreeze(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RegulatoryReportTypeMaint regulatoryReportTypeMaint,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.UnFreeze(regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject regulatoryReportTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RegulatoryReportTypeMaint) regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) parameters, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject regulatoryReportTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RegulatoryReportTypeMaint) regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) parameters, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject regulatoryReportTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RegulatoryReportTypeMaint) regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_LoadESigDetails_Parameters) parameters, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject regulatoryReportTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus resultStatus = this.New((RegulatoryReportTypeMaint) regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) parameters, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject regulatoryReportTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RegulatoryReportTypeMaint) regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) parameters, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject regulatoryReportTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RegulatoryReportTypeMaint) regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) parameters, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject regulatoryReportTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RegulatoryReportTypeMaint) regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) parameters, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject regulatoryReportTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus resultStatus = this.Load((RegulatoryReportTypeMaint) regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) parameters, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject regulatoryReportTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RegulatoryReportTypeMaint) regulatoryReportTypeMaint, (RegulatoryReportTypeMaint_Parameters) parameters, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      try
      {
        RegulatoryReportTypeMaintMethod[] methods = new RegulatoryReportTypeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRegulatoryReportTypeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RegulatoryReportTypeMaint cdo,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      try
      {
        return ((IRegulatoryReportTypeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RegulatoryReportTypeMaint) cdo, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.GetEnvironment((RegulatoryReportTypeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RegulatoryReportTypeMaint cdo,
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      result = (RegulatoryReportTypeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRegulatoryReportTypeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(cdo, RegulatoryReportTypeMaintMethods.ExecuteTransaction, (RegulatoryReportTypeMaint_Parameters) null));
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
        RegulatoryReportTypeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RegulatoryReportTypeMaint) cdo, (RegulatoryReportTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RegulatoryReportTypeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RegulatoryReportTypeMaint_Request) null, out RegulatoryReportTypeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RegulatoryReportTypeMaint_Request request,
      out RegulatoryReportTypeMaint_Result result)
    {
      return this.ExecuteTransaction((RegulatoryReportTypeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RegulatoryReportTypeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RegulatoryReportTypeMaintMethod(cdo, RegulatoryReportTypeMaintMethods.AddDataTransaction, (RegulatoryReportTypeMaint_Parameters) null));
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
        return this.AddDataTransaction((RegulatoryReportTypeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
