def field(items, *args):
    assert len(args) > 0

    if len(args) == 1:
        for item in items:
            yield item.get(args[0], None)
    else:
        for item in items:
            result = {key: item.get(key, None) for key in args}
            if any(result.values()):
                yield result
