# BrightChain
- BrightChain Engine in C#/.Net 6 (Currently requires VS 2022 Preview, or IntelliJ Rider)
- BrightNet BlockStore and API for BrightChain: The Revolution(ary) Network
- The old wiki: https://github.com/The-Revolution-Network/brightChainAPI/wiki/Introduction
- The new wiki: https://github.com/The-Revolution-Network/BrightChain/wiki (old will be rewritten/migrated)
- Auto-generated documentation: http://apidocs.therevolution.network/api/index.html
  - Note that some of the classes don't have docblocks yet, but I've gotten many. The "TODO/example" text is in place as well, but if you click into the sections the content is there.
- Coming soon (GitHub Pages): https://the-revolution-network.github.io/gh-pages/

Recent thoughts:
 - If you haven't noticed- BrightChain is almost BrightChainS with an S. It's a pool of chains. Each with its own value.
 - Something I was implementing in the old code but haven't yet gotten to is also a deduplication for public blocks. Basically any chain that has its CBL block committed to the network will have the hash of the overall chain checked for deduplication.
 - Likely to use https://dapr.io https://github.com/dapr for node sync in the near future.
 - API throttle will continue as planned to be mathematically rate limited by minimal proof of works for bad actors and an algorithm to determine the maximum request r/w rates.
 - Block consensus will be proof of stake
 - its more of a brightnet blockstore and an ethos... what it needs still is some math and a little more vision in the areas I'm not seeing.
 - The whole goal is to reward people who contribute good, frequently accessed content, the storage for it, etc.
 - Everything is tracked in terms of a unit called the Joule - wondering about using a micro-unit Jansky.
 - - Attempting to be somewhat synonymous with the real work unit.
 - - There should ideally be a direct maths.
  - Ultimately bad users are just bad blocks and will get flushed and expired out while good stuff will get extended on forever. They will have to work too hard for their network access/wasteful contribution/access and will leave.
  - It is not the necessity of this chain to store every bit forever. The chain is very transparent and ultimately when things do expire out if not needed by the system, others can easily back them up. Some blocks of course are immediately set immutable with a DateTime.MaxValue and don't need to be renewed.

# Disclaimers
* This project is still pre-Alpha and is not suitable nor warranted for any level of fitness or function.
* This project is not affiliated with GitHub, The DotNet Foundation, Microsoft, or any of its affiliates or holdings.
* This software is open source, and offered as a "best-effort" thereoetical construct at this time and it may well lose all your data at this point in time.

<!-- this timestamp is updated by a pre-commit hook in git-hooks/pre-commit then added to .git/hooks -->
Last Updated: <time class="timestamp" timestamp="ISO 8601 string">2021-06-27T08:47:40-0700</time>
