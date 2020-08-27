// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.FilterTagMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class FilterTagMaintService : UserCodeMaintBase
  {
    public FilterTagMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IFilterTagMaintService), userProfile);
    }

    public ResultStatus Delete(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) filterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagMaintService) this._Channel).Delete(this._UserProfile, filterTagMaint, parameters, request, out result) : this.AddMethod((Method) new FilterTagMaintMethod(filterTagMaint, FilterTagMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) filterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((FilterTagMaint) null, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus Delete(FilterTagMaint filterTagMaint)
    {
      return this.Delete(filterTagMaint, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus Delete(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.Delete(filterTagMaint, (FilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) filterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagMaintService) this._Channel).Freeze(this._UserProfile, filterTagMaint, parameters, request, out result) : this.AddMethod((Method) new FilterTagMaintMethod(filterTagMaint, FilterTagMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) filterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((FilterTagMaint) null, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus Freeze(FilterTagMaint filterTagMaint)
    {
      return this.Freeze(filterTagMaint, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus Freeze(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.Freeze(filterTagMaint, (FilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) filterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagMaintService) this._Channel).GetWIPMsgs(this._UserProfile, filterTagMaint, parameters, request, out result) : this.AddMethod((Method) new FilterTagMaintMethod(filterTagMaint, FilterTagMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) filterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((FilterTagMaint) null, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(FilterTagMaint filterTagMaint)
    {
      return this.GetWIPMsgs(filterTagMaint, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.GetWIPMsgs(filterTagMaint, (FilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) filterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagMaintService) this._Channel).Load(this._UserProfile, filterTagMaint, parameters, request, out result) : this.AddMethod((Method) new FilterTagMaintMethod(filterTagMaint, FilterTagMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) filterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((FilterTagMaint) null, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus Load(FilterTagMaint filterTagMaint)
    {
      return this.Load(filterTagMaint, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus Load(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.Load(filterTagMaint, (FilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_LoadESigDetails_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) filterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagMaintService) this._Channel).LoadESigDetails(this._UserProfile, filterTagMaint, parameters, request, out result) : this.AddMethod((Method) new FilterTagMaintMethod(filterTagMaint, FilterTagMaintMethods.LoadESigDetails, (FilterTagMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) filterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((FilterTagMaint) null, (FilterTagMaint_LoadESigDetails_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus LoadESigDetails(FilterTagMaint filterTagMaint)
    {
      return this.LoadESigDetails(filterTagMaint, (FilterTagMaint_LoadESigDetails_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.LoadESigDetails(filterTagMaint, (FilterTagMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) filterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagMaintService) this._Channel).New(this._UserProfile, filterTagMaint, parameters, request, out result) : this.AddMethod((Method) new FilterTagMaintMethod(filterTagMaint, FilterTagMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) filterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((FilterTagMaint) null, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus New(FilterTagMaint filterTagMaint)
    {
      return this.New(filterTagMaint, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus New(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.New(filterTagMaint, (FilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) filterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagMaintService) this._Channel).NewCopy(this._UserProfile, filterTagMaint, parameters, request, out result) : this.AddMethod((Method) new FilterTagMaintMethod(filterTagMaint, FilterTagMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) filterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((FilterTagMaint) null, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus NewCopy(FilterTagMaint filterTagMaint)
    {
      return this.NewCopy(filterTagMaint, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus NewCopy(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.NewCopy(filterTagMaint, (FilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) filterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagMaintService) this._Channel).SaveAs(this._UserProfile, filterTagMaint, parameters, request, out result) : this.AddMethod((Method) new FilterTagMaintMethod(filterTagMaint, FilterTagMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) filterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((FilterTagMaint) null, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus SaveAs(FilterTagMaint filterTagMaint)
    {
      return this.SaveAs(filterTagMaint, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus SaveAs(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.SaveAs(filterTagMaint, (FilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Parameters parameters,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) filterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagMaintService) this._Channel).UnFreeze(this._UserProfile, filterTagMaint, parameters, request, out result) : this.AddMethod((Method) new FilterTagMaintMethod(filterTagMaint, FilterTagMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) filterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((FilterTagMaint) null, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus UnFreeze(FilterTagMaint filterTagMaint)
    {
      return this.UnFreeze(filterTagMaint, (FilterTagMaint_Parameters) null, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus UnFreeze(
      FilterTagMaint filterTagMaint,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.UnFreeze(filterTagMaint, (FilterTagMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject filterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FilterTagMaint_Result result1;
        ResultStatus resultStatus = this.Delete((FilterTagMaint) filterTagMaint, (FilterTagMaint_Parameters) parameters, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject filterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FilterTagMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((FilterTagMaint) filterTagMaint, (FilterTagMaint_Parameters) parameters, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject filterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FilterTagMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((FilterTagMaint) filterTagMaint, (FilterTagMaint_LoadESigDetails_Parameters) parameters, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject filterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FilterTagMaint_Result result1;
        ResultStatus resultStatus = this.New((FilterTagMaint) filterTagMaint, (FilterTagMaint_Parameters) parameters, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject filterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FilterTagMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((FilterTagMaint) filterTagMaint, (FilterTagMaint_Parameters) parameters, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject filterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FilterTagMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((FilterTagMaint) filterTagMaint, (FilterTagMaint_Parameters) parameters, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject filterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FilterTagMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((FilterTagMaint) filterTagMaint, (FilterTagMaint_Parameters) parameters, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject filterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FilterTagMaint_Result result1;
        ResultStatus resultStatus = this.Load((FilterTagMaint) filterTagMaint, (FilterTagMaint_Parameters) parameters, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject filterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FilterTagMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((FilterTagMaint) filterTagMaint, (FilterTagMaint_Parameters) parameters, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      try
      {
        FilterTagMaintMethod[] methods = new FilterTagMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IFilterTagMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        FilterTagMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FilterTagMaint cdo,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      try
      {
        return ((IFilterTagMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        FilterTagMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((FilterTagMaint) cdo, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.GetEnvironment((FilterTagMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      FilterTagMaint cdo,
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      result = (FilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFilterTagMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new FilterTagMaintMethod(cdo, FilterTagMaintMethods.ExecuteTransaction, (FilterTagMaint_Parameters) null));
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
        FilterTagMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((FilterTagMaint) cdo, (FilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(FilterTagMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (FilterTagMaint_Request) null, out FilterTagMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      FilterTagMaint_Request request,
      out FilterTagMaint_Result result)
    {
      return this.ExecuteTransaction((FilterTagMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(FilterTagMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new FilterTagMaintMethod(cdo, FilterTagMaintMethods.AddDataTransaction, (FilterTagMaint_Parameters) null));
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
        return this.AddDataTransaction((FilterTagMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
